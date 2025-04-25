// TODO - poprawić, aby nie dało się nadpisywać profili tylko żeby wywalało jakiś błąd

using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
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
    public partial class Form_CreateProfile : Form
    {
        public Form_CreateProfile()
        {
            InitializeComponent();
        }

        private void Button_CreateProfile_Click(object sender, EventArgs e)
        {
            Base_SemestrProfile Profile = new Base_SemestrProfile();

            Profile.Name = TextBox_ProfileName.Text;

            Profile.ListOfSubjects = Side_Format.CutIntoSingleWords(RichTextBox_ListOfSubjects.Text);

            Profile.SaveDataToFile();

            this.Close();
            this.Hide();

            Form_Logging form_Logging = new Form_Logging();
            form_Logging.Show();

        }

        private void Button_ExitProfileCreator_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            Form_Logging form_Logging = new Form_Logging();
            form_Logging.Show();
        }
    }
}
