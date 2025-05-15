using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Side;
using CRUDAppProject.CS.Tasks;
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
    public partial class Form_CreateProj : Form
    {
        private void FillComboBox()
        {
            foreach (string item in Base_AppState.ChosenProfileSubjects)
                ComboBox_ChooseSubject.Items.Add(item);
        }

        public Form_CreateProj()
        {
            InitializeComponent();
            Calendar_SetDeadline.MaxSelectionCount = 1;
            Calendar_SetDeadline.MinDate = DateTime.Now.Date;
            FillComboBox();
        }

        private void Button_CreateProject_Click(object sender, EventArgs e)
        {
            try
            {
                Task_Proj task = new Task_Proj();
                task.Title = TextBox_TaskTitle.Text;
                task.ShortDescription = TextBox_ShortDescription.Text;
                task.Description = RichTextBox_TaskDescription.Text;
                task.Members = TextBox_TaskMembers.Text;
                task.ChosenSubject = Side_Format.CapitalizeString(ComboBox_ChooseSubject.Text);
                task.Deadline = Calendar_SetDeadline.SelectionStart;
                task.CreateTask(task);
                this.Hide();
                this.Close();
                Form_LoggedIn screen_LoggedIn = new Form_LoggedIn();
                screen_LoggedIn.Show();

            }

            catch (ArgumentException ex)
            {
                if (ex.ParamName == "TaskTitleNullOrEmpty")
                    MessageBox.Show("Nazwa projektu nie może być pusta!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "TaskDescriptionNullOrEmpty")
                    MessageBox.Show("Opis projektu nie może być pusty!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "SubjectNotFound")
                    MessageBox.Show("Wybrany przedmiot nie istnieje w liście zapisanych przedmiotów dla danego profilu!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "ProjectMembersSourceNullOrEmpty")
                    MessageBox.Show("Lista członków nie może być pusta!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "ShortDescriptionTooLong")
                    MessageBox.Show("Krótki opis jest za długi! Maksymalnie 32 znaki!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "EmptyShortDescription")
                    MessageBox.Show("Krótki opis nie może być pusty!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "FATALTaskTypeConflict")
                    MessageBox.Show("FATAL: konflikt typów zadań!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Button_ExitProjectCreator_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
            screenLoggedIn.Show();
        }
    }
}
