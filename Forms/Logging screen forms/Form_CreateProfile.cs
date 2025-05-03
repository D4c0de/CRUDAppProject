using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Interfaces;
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
                        

            try
            {
                Profile.SaveDataToFile();

                // Jeśli wszystko ok - cofnij się do głównego ekranu logowania

                this.Close();
                this.Hide();
                Form_Logging form_Logging = new Form_Logging();
                form_Logging.Show();
            }


            // Obsłuż wyjątek, w którym lista jest pusta (bo to jedyny wyjątek jaki wyrzucamy)
            // Profil nie ma żadnej nazwy tylko działa
            catch (ArgumentException ex)
            {
                if(ex.ParamName == "FileAlreadyExists")
                {
                    MessageBox.Show(ex.Message, "Nazwy profili nie mogą się powtarzać.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (ex.ParamName == "EmptyListOfSubjects")
                {
                    MessageBox.Show(ex.Message, "Lista nie może być pusta.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (ex.ParamName == "NullOrEmptyFileName")
                {
                    MessageBox.Show(ex.Message, "Nazwa profilu nie może być pusta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void Button_ExitProfileCreator_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();
        }
    }
}
