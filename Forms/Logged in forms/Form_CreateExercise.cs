using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Static;
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
    public partial class Form_CreateExercise : Form
    {
        public Form_CreateExercise()
        {
            
            InitializeComponent();
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
                task.Description = RichTextBox_TaskDescription.Text;
                task.TaskSource = RichTextBox_TaskSource.Text;
                task.ChosenSubject = Side_Format.CapitalizeString(ComboBox_ChooseSubject.Text);
                task.Status = task.TupleOfStatuses.TODO;
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

                else if (ex.ParamName == "TaskDescriptionNullOrEmpty")
                    MessageBox.Show("Opis zadania nie może być pusty!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                else if (ex.ParamName == "SubjectNotFound")
                    MessageBox.Show("Wybrany przedmiot nie istnieje w liście zapisanych przedmiotów dla danego profilu!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                else if (ex.ParamName == "ExerciseSourceNullOrEmpty")
                    MessageBox.Show("Źródło zadania nie może być puste!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "FATALTaskTypeConflict")
                    MessageBox.Show("FATAL: konflikt typów zadań!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
