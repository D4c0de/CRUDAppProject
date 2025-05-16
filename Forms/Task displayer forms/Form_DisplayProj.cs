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
    partial class Form_DisplayProj: Form
    {
        Task_Proj ActiveTask = new Task_Proj();

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
            ActiveTask = task;
            FillAllTextBoxes(ActiveTask);
        }

        private void Button_ExitProjectDisplayer_Click(object sender, EventArgs e)
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
                ActiveTask.RemoveTask(ActiveTask);
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
            Form_EditProj screenEditProj = new Form_EditProj(ActiveTask);
            screenEditProj.Show();
        }
    }
}
