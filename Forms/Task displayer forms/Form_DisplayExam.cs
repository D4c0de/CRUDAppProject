using CRUDAppProject.CS.Tasks;
using CRUDAppProject.Forms.Task_editor_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAppProject.Forms.Task_display_forms
{
    partial class Form_DisplayExam : Form
    {
        Task_Exam ActiveTask = new Task_Exam();

        private void FillAllTextBoxes(Task_Exam task)
        {
            TextBox_TaskTitle.Text = task.Title;
            TextBox_ShortDescription.Text = task.ShortDescription;
            TextBox_TaskSubject.Text = task.ChosenSubject;
            RichTextBox_TaskDescription.Text = task.Description;
            TextBox_TaskDeadline.Text = task.Deadline.ToShortDateString();
            RichTextBox_TaskMaterialScope.Text = task.MaterialScope;
        }

        public Form_DisplayExam(Task_Exam task)
        {
            InitializeComponent();
            ActiveTask = task;
            FillAllTextBoxes(ActiveTask);
        }

        private void Button_ExitExamDisplayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
            screenLoggedIn.Show();
        }

        private void Button_RemoveTask_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Czy na pewno chcesz usunąć to zadanie?",
                "Potwierdzenie usunięcia",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.OK)
            {
                ActiveTask.RemoveTask();
                this.Hide();
                this.Close();
                Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
                screenLoggedIn.Show();
            }
        }

        private void Button_EditTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_EditExam screenEditExam = new Form_EditExam(ActiveTask);
            screenEditExam.Show();
        }
    }
}
