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

namespace CRUDAppProject.Forms.Task_display_forms
{
    partial class Form_DisplayProj: Form
    {
        private void FillAllTextBoxes(Task_Proj task)
        {
            TextBox_TaskTitle.Text = task.Title;
            TextBox_ShortDescription.Text = task.ShortDescription;
            TextBox_TaskSubject.Text = task.ChosenSubject;
            RichTextBox_TaskDescription.Text = task.Description;
            TextBox_TaskDeadline.Text = task.Deadline.ToShortDateString();
            TextBox_TaskMembers.Text = task.Members;
        }

        public Form_DisplayProj(Task_Proj task)
        {
            InitializeComponent();
            FillAllTextBoxes(task);
        }

        private void Button_ExitProjectDisplayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_LoggedIn screenLoggedIn = new Form_LoggedIn();
            screenLoggedIn.Show();
        }

    }
}
