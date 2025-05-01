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
    public partial class Form_ChooseProfile : Form
    {
        public Form_ChooseProfile()
        {
            InitializeComponent();
            Base_SemestrProfile.LoadAllProfilesFromFile(ComboBox_ProfileName);
        }


        // DODAĆ DO FUNKCJI PONIŻEJ LOGIKĘ OTWIERANIA FORMY PO ZALOGOWANIU
        private void ChooseProfileToLogIn()
        {
            string pathOfProfileToDelete = $"{Base_SemestrProfile.CrudaFolderPath}\\{Side_Format.CapitalizeString(ComboBox_ProfileName.Text)}.json";

            if (Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToDelete))
            {
                Base_AppState.ChosenProfile = Side_Format.CapitalizeString(ComboBox_ProfileName.Text);
                Base_AppState.ChosenProfileSubjects = Base_SemestrProfile.LoadListOfSubjectFromFile();

                foreach(string subject in Base_AppState.ChosenProfileSubjects)
                    Console.WriteLine(subject);

                this.Hide();
                this.Close();
            }

            else if (!Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToDelete))
            {
                throw new ArgumentException("Nie znaleziono profilu!", "ProfileNotFound");
            }
        }

        private void Button_LogIn_Click(object sender, EventArgs e)
        {            
            try
            {
                ChooseProfileToLogIn();
                Form_LoggedIn Screen_LoggedIn = new Form_LoggedIn();
                Screen_LoggedIn.Show();

            }

            catch (ArgumentException ex)
            {
                if(ex.ParamName == "ProfileNotFound")
                    MessageBox.Show("Profil na który chcesz się zalogować nie istnieje!", "Logowanie nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Button_ExitProfileChoosing_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();            
        }

        private void Form_ChooseProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
