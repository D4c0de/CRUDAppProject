using CRUDAppProject.CS.Base;
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
                throw new ArgumentException("Żaden profil nie został nigdy stworzony!", "CRUDADictionaryDoesNotExist");

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
            foreach (string profileName in ListOfAllProfiles)
            {
                //Path.GetFileName(profileName.Remove(profileName.Length - 5));
            }
        }

        private void Form_DeleteProfile_Load(object sender, EventArgs e)
        {

        }


    }
}
