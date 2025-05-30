using CRUDAppProject.CS.Base;
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

namespace CRUDAppProject.Forms.Task_editor_forms
{
    partial class Form_EditProj : Form
    {
        private static Task_Proj ActiveTask = new Task_Proj();

        private void FillAllTextBoxes(Task_Proj task)
        {
            TextBox_TaskTitle.Text = task.Title;
            TextBox_ShortDescription.Text = task.ShortDescription;
            ComboBox_ChooseSubject.Text = task.ChosenSubject;
            RichTextBox_TaskDescription.Text = task.Description;

            if (Calendar_SetDeadline.MinDate > task.Deadline)
                Calendar_SetDeadline.MinDate = task.Deadline.Date;

            if (Calendar_SetDeadline.MaxDate < task.Deadline)
                Calendar_SetDeadline.MaxDate = task.Deadline.Date;

            Calendar_SetDeadline.SelectionStart = task.Deadline;
            Calendar_SetDeadline.SelectionEnd = task.Deadline;
            TextBox_TaskMembers.Text = task.Members;
        }

        private void FillComboBox()
        {
            foreach (string item in Base_AppState.ChosenProfileSubjects)
                ComboBox_ChooseSubject.Items.Add(item);
        }

        private Task_Proj GetEditedData()
        {
            Task_Proj task = new Task_Proj();

            task.Title = TextBox_TaskTitle.Text;
            task.ShortDescription = TextBox_ShortDescription.Text;
            task.ChosenSubject = ComboBox_ChooseSubject.Text;
            task.Description = RichTextBox_TaskDescription.Text;
            task.Deadline = Calendar_SetDeadline.SelectionStart;
            task.Members = TextBox_TaskMembers.Text;
            return task;
        }

        public Form_EditProj(Task_Proj task)
        {
            InitializeComponent();
            ActiveTask = task;
            Calendar_SetDeadline.MaxSelectionCount = 1;
            Calendar_SetDeadline.MinDate = task.DateOfCreation;
            FillAllTextBoxes(ActiveTask);
            FillComboBox();
        }

        private void Button_SaveEditedProj_Click(object sender, EventArgs e)
        {
            try
            {
                Task_Proj editedTask = new Task_Proj();
                editedTask = GetEditedData();
                editedTask.CreateTask();
                ActiveTask.RemoveTask();
                this.Hide();
                this.Close();
                Form_LoggedIn screen_LoggedIn = new Form_LoggedIn();
                screen_LoggedIn.Show();
            }

            catch (ArgumentException ex)
            {
                if (ex.ParamName == "TaskTitleNullOrEmpty")
                    MessageBox.Show("Nazwa projektu nie może być pusta!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "TaskTitleTooLong")
                    MessageBox.Show("Nazwa zadania za długa! Maksymalnie 32 znaki!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "SubjectNotFound")
                    MessageBox.Show("Wybrany przedmiot nie istnieje w liście zapisanych przedmiotów dla danego profilu!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "ProjectMembersSourceNullOrEmpty")
                    MessageBox.Show("Lista członków nie może być pusta!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "ShortDescriptionTooLong")
                    MessageBox.Show("Krótki opis jest za długi! Maksymalnie 32 znaki!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "EmptyShortDescription")
                    MessageBox.Show("Krótki opis nie może być pusty!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "FATALTaskTypeConflict")
                    MessageBox.Show("FATAL: konflikt typów zadań!", "Tworzenie projektu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Button_ExitProjEditor_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
            screenLoggedIn.Show();
        }
    }
}
