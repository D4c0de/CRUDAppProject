// TODO: dodać logikę zapisywania profilu w formie plików .JSON


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
    public partial class Form_CreateProfile : Form
    {
        public Form_CreateProfile()
        {
            InitializeComponent();
        }


        private void Label_WelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void Form_CreateProfile_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_ProfileName_TextChanged(object sender, EventArgs e)
        {


        }

        private void RichTextBox_ListOfSubjects_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void Button_CreateProfile_Click(object sender, EventArgs e)
        {
            Base_SemestrProfile Profile = new Base_SemestrProfile();

            Profile.Name = TextBox_ProfileName.Text;

            Profile.ListOfSubjects = Side_Format.CutIntoSingleWords(RichTextBox_ListOfSubjects.Text);

            this.Close();
            this.Hide();

            Console.WriteLine($"Nazwa profilu: {Profile.Name}");
            Console.WriteLine($"Ilosc przedmiotow: {Profile.ListOfSubjects.Count}");
            Console.WriteLine("Przedmioty: ");
            foreach(var sub in Profile.ListOfSubjects)
            {
                Console.WriteLine($"{sub}.");
            }


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
