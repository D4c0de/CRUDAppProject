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
    public partial class Form_CreateExam: Form
    {

        private void FillComboBox()
        {
            foreach (string item in Base_AppState.ChosenProfileSubjects)
                ComboBox_ChooseSubject.Items.Add(item);
        }

        public Form_CreateExam()
        {
            InitializeComponent();
            Calendar_SetDeadline.MaxSelectionCount = 1;
            Calendar_SetDeadline.MinDate = DateTime.Now.Date;
            FillComboBox();
        }

        private void Button_CreateExam_Click(object sender, EventArgs e)
        {
            try
            {

                Task_Exam task = new Task_Exam();
                task.Title = TextBox_TaskTitle.Text;
                task.Description = RichTextBox_TaskDescription.Text;
                task.MaterialScope = RichTextBox_TaskMaterialScope.Text;
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
                    MessageBox.Show("Nazwa egzaminu nie może być pusta!", "Tworzenie egzaminu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "TaskDescriptionNullOrEmpty")
                    MessageBox.Show("Opis egzaminu nie może być pusty!", "Tworzenie egzaminu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "SubjectNotFound")
                    MessageBox.Show("Wybrany przedmiot nie istnieje w liście zapisanych przedmiotów dla danego profilu!", "Tworzenie egzaminu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "ExamMaterialScopeNullOrEmpty")
                    MessageBox.Show("Materiał do nauki nie może być pusty!", "Tworzenie egzaminu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (ex.ParamName == "FATALTaskTypeConflict")
                    MessageBox.Show("FATAL: konflikt typów zadań!", "Tworzenie egzaminu nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
