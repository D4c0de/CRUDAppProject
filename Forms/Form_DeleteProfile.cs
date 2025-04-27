using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAppProject.Forms
{
    public partial class Form_DeleteProfile : Form
    {

        /// <summary>
        /// Lista wszystkich profili, czyli plików z roszrzerzeniem .json
        /// </summary>

        public static List<string> ListOfAllProfiles = new List<string>();


        public static void LoadAllProfilesFromFile(ComboBox cb)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string crudaFolderPath = Path.Combine(appDataPath, Base_SemestrProfile.NameOfAppDataFolder);

            if (!Directory.Exists(crudaFolderPath))
                throw new ArgumentException("Żaden profil nie został nigdy stworzony!", "CRUDADirectoryDoesNotExist");

            else
            {
                ListOfAllProfiles = Directory.GetFiles(crudaFolderPath, "*.json").ToList<string>();
                                

                if (ListOfAllProfiles.Count <= 0)
                    throw new ArgumentException("Brak profili w systemie!", "NoProfilesFound");

                
                else if (ListOfAllProfiles.Count > 0)
                {
                    foreach (string profileName in ListOfAllProfiles)
                    {
                        cb.Items.Add(Path.GetFileName(profileName.Remove(profileName.Length - 5)));
                    }
                }
            }
        }

        public Form_DeleteProfile()
        {
            
            InitializeComponent();
            LoadAllProfilesFromFile(ComboBox_ProfileName);
        }

        private void Button_ExitProfileDeletion_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();
        }

        private void Button_ConfirmProfileDeletion_Click(object sender, EventArgs e)
        {

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string crudaFolderPath = Path.Combine(appDataPath, Base_SemestrProfile.NameOfAppDataFolder);
            string pathOfProfileToDelete = $"{crudaFolderPath}\\{Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text)}.json";

            try
            {
                if (ListOfAllProfiles.Contains(pathOfProfileToDelete) && ComboBox_ProfileName.Text == Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text))
                {
                    File.Delete(pathOfProfileToDelete);
                    MessageBox.Show("Usuwanie profilu powiodło się.", "Usuwanie profilu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    this.Close();
                    Form_Logging Screen_Logging = new Form_Logging();
                    Screen_Logging.Show();
                }

                else if (!ListOfAllProfiles.Contains(pathOfProfileToDelete))
                    throw new ArgumentException("Nie znaleziono profilu!", "ProfileNotFound");


                else if (ListOfAllProfiles.Contains(pathOfProfileToDelete) && ComboBox_ProfileName.Text != Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text))
                    throw new ArgumentException("Nazwy się nie zgadzają!", "NamesDoNotMatch");
            }



            catch (ArgumentException ex)
            {
                if (ex.ParamName == "CRUDADirectoryDoesNotExist")
                    MessageBox.Show("Usuwanie profilu nie powiodło się.", "Żaden profil nie został nigdy utworzony!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "NoProfilesFound")
                    MessageBox.Show("Usuwanie profilu nie powiodło się.", "Brak zapisanych profili w systemie!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "ProfileNotFound")
                    MessageBox.Show("Usuwanie profilu nie powiodło się.", "Profil który chcesz usunać nie istnieje!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "NamesDoNotMatch")
                    MessageBox.Show("Usuwanie profilu nie powiodło się.", "Nazwa profilu do usunięcia nie zgadza się z wpisaną frazą!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_DeleteProfile_Load(object sender, EventArgs e)
        {

        }


    }
}
