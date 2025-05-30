using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Side;
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

        private void ChooseProfileToLogIn()
        {
            string pathOfProfileToLogIn = $"{Base_SemestrProfile.CrudaFolderPath}\\{Side_Format.CapitalizeString(ComboBox_ProfileName.Text)}.json";

            if (Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToLogIn))
            {
                Base_AppState.ChosenProfile = Side_Format.CapitalizeString(ComboBox_ProfileName.Text);
                Base_AppState.ChosenProfileSubjects = Base_SemestrProfile.LoadListOfSubjectFromFile();
                this.Hide();
                this.Close();
            }

            else if (!Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToLogIn))
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
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();
            this.Hide();
            this.Close();            
        }
    }
}
