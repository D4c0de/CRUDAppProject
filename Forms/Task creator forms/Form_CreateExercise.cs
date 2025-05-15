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

namespace CRUDAppProject.Forms.Logged_in_forms
{
    partial class Form_CreateExercise : Form
    {
        public Form_CreateExercise()
        {
            InitializeComponent();
            Calendar_SetDeadline.MaxSelectionCount = 1;
            Calendar_SetDeadline.MinDate = DateTime.Now.Date;
            FillComboBox();
        }

        private void FillComboBox()
        {
            foreach (string item in Base_AppState.ChosenProfileSubjects)
                ComboBox_ChooseSubject.Items.Add(item);
        }

        private void Button_CreateExercise_Click(object sender, EventArgs e)
        {
            try
            {
                Task_Exercise task = new Task_Exercise();
                task.Title = TextBox_TaskTitle.Text;
                task.ShortDescription = TextBox_ShortDescription.Text;
                task.Description = RichTextBox_TaskDescription.Text;
                task.TaskSource = RichTextBox_TaskSource.Text;
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
                    MessageBox.Show("Nazwa zadania nie może być pusta!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "TaskTitleTooLong")
                    MessageBox.Show("Nazwa zadania za długa! Maksymalnie 32 znaki!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "SubjectNotFound")
                    MessageBox.Show("Wybrany przedmiot nie istnieje w liście zapisanych przedmiotów dla danego profilu!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "ExerciseSourceNullOrEmpty")
                    MessageBox.Show("Źródło zadania nie może być puste!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "ShortDescriptionTooLong")
                    MessageBox.Show("Krótki opis jest za długi! Maksymalnie 32 znaki!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "EmptyShortDescription")
                    MessageBox.Show("Krótki opis nie może być pusty!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "FATALTaskTypeConflict")
                    MessageBox.Show("FATAL: konflikt typów zadań!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_ExitExerciseCreator_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
            screenLoggedIn.Show();
        }

        public void SwitchToEditForm(Task_Exercise task)
        {
            Label_WelcomeMessage.Text = "Edytor ćwiczenia";
            Button_CreateExercise.Text = "Zapisz zadanie";

            TextBox_TaskTitle.Text = task.Title;
            TextBox_ShortDescription.Text = task.ShortDescription;
            RichTextBox_TaskDescription.Text = task.Description;
            RichTextBox_TaskSource.Text = task.TaskSource;
            ComboBox_ChooseSubject.Text = task.ChosenSubject;
            Calendar_SetDeadline.SelectionStart = task.Deadline;
            Calendar_SetDeadline.SelectionEnd = task.Deadline;
        }
    }
}
