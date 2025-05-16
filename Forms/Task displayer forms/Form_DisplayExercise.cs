using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAppProject.Forms.Task_display_forms
{
    partial class Form_DisplayExercise : Form
    {
        Task_Exercise ActiveTask = new Task_Exercise();

        private void FillAllTextBoxes(Task_Exercise task)
        {
            TextBox_TaskTitle.Text = task.Title;
            TextBox_ShortDescription.Text = task.ShortDescription;
            TextBox_TaskSubject.Text = task.ChosenSubject;
            RichTextBox_TaskDescription.Text = task.Description;
            TextBox_TaskDeadline.Text = task.Deadline.ToShortDateString();
            RichTextBox_TaskSource.Text = task.TaskSource;
        }

        public Form_DisplayExercise(Task_Exercise task)
        {
            InitializeComponent();
            ActiveTask = task;
            FillAllTextBoxes(ActiveTask);
        }

        private void Button_ExitExerciseDisplayer_Click(object sender, EventArgs e)
        {            
            this.Hide();
            this.Close();
            Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
            screenLoggedIn.Show();
        }

        private void Button_EditTask_Click(object sender, EventArgs e)
        {

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
                ActiveTask.RemoveTask(ActiveTask);
                this.Hide();
                this.Close();
                Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
                screenLoggedIn.Show();
            }
        }
    }
}
