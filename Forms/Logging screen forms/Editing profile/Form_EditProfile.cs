using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Side;
using CRUDAppProject.Forms.Logging_screen_forms.Editing_profile;
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
    public partial class Form_EditProfile: Form
    {
        public Form_EditProfile()
        {
            InitializeComponent();
            Base_SemestrProfile.LoadAllProfilesFromFile(ComboBox_ProfileName);
        }
        private void ChooseProfileToEdit()
        {
            string pathOfProfileToEdit = $"{Base_SemestrProfile.CrudaFolderPath}\\{Side_Format.CapitalizeString(ComboBox_ProfileName.Text)}.json";

            if (Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToEdit))
            {
                Base_AppState.ChosenProfile = Side_Format.CapitalizeString(ComboBox_ProfileName.Text);
                Base_AppState.ChosenProfileSubjects = Base_SemestrProfile.LoadListOfSubjectFromFile();
                this.Hide();
                this.Close();
            }

            else if (!Base_SemestrProfile.ListOfAllProfiles.Contains(pathOfProfileToEdit))
                throw new ArgumentException("Nie znaleziono profilu!", "ProfileNotFound");
        }
                

        private void Button_ExitProfileEditing_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();            
            Form_Logging screenLogging = new Form_Logging();
            screenLogging.Show();
        }

        private void Button_EditChosenProfile_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseProfileToEdit();
                this.Close();
                this.Hide();
                Form_ProfileEditor screenProfileEditor = new Form_ProfileEditor();
                screenProfileEditor.Show();
            }

            catch (ArgumentException ex)
            {
                if (ex.ParamName == "ProfileNotFound")
                    MessageBox.Show("Profil na który chcesz się zalogować nie istnieje!", "Logowanie nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
