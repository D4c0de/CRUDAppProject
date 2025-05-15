using CRUDAppProject.CS.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            FillAllTextBoxes(task);
        }

        private void Button_ExitExerciseDisplayer_Click(object sender, EventArgs e)
        {            
            this.Hide();
            this.Close();
            Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
            screenLoggedIn.Show();
        }
    }
}
