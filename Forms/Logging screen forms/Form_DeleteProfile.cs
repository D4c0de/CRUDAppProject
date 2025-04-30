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
        public Form_DeleteProfile()
        {            
            InitializeComponent();
            Base_SemestrProfile.LoadAllProfilesFromFile(ComboBox_ProfileName);
        }
        
        private void Button_ExitProfileDeletion_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();
        }


        /// <summary>
        /// Logika usunięcia i usunięcie wybranego profilu 
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        
        private void DeleteProfileFromFolder()
        {

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string crudaFolderPath = Path.Combine(appDataPath, Base_SemestrProfile.NameOfAppDataFolder);
            string pathOfProfileToDelete = $"{crudaFolderPath}\\{Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text)}.json";

            if (Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToDelete) && ComboBox_ProfileName.Text == Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text))
            {
                File.Delete(pathOfProfileToDelete);
                MessageBox.Show("Usuwanie profilu powiodło się.", "Usuwanie profilu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                this.Close();
            }

            else if (!Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToDelete))
                throw new ArgumentException("Nie znaleziono profilu!", "ProfileNotFound");


            else if (Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToDelete) && ComboBox_ProfileName.Text != Side_Format.CapitalizeString(TextBox_RewriteProfileName.Text))
                throw new ArgumentException("Nazwy się nie zgadzają!", "NamesDoNotMatch");
        }


        private void Button_ConfirmProfileDeletion_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteProfileFromFolder();
                Form_Logging Screen_Logging = new Form_Logging();
                Screen_Logging.Show();
            }

            catch (ArgumentException ex)
            {
                if (ex.ParamName == "ProfileNotFound")
                    MessageBox.Show("Profil który chcesz usunać nie istnieje!", "Usuwanie profilu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "NamesDoNotMatch")
                    MessageBox.Show("Nazwa profilu do usunięcia nie zgadza się z wpisaną frazą!", "Usuwanie profilu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_DeleteProfile_Load(object sender, EventArgs e)
        {

        }


    }
}
