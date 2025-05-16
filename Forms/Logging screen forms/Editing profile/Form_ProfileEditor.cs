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

namespace CRUDAppProject.Forms.Logging_screen_forms.Editing_profile
{
    partial class Form_ProfileEditor: Form
    {
        public Form_ProfileEditor()
        {
            InitializeComponent();
            TextBox_ProfileName.Text = Base_AppState.ChosenProfile;
            RichTextBox_ListOfSubjects.Text = Side_Format.JoinWordsIntoString(Base_AppState.ChosenProfileSubjects);
        }

        private void Button_ExitProfileEditor_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_Logging screenLogging = new Form_Logging();
            screenLogging.Show();
        }

        private void Button_SaveEditedProfile_Click(object sender, EventArgs e)
        {

        }

    }
}
