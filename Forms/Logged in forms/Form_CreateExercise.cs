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
                task.ChosenSubject = Side_Format.CapitalizeString(ComboBox_ChooseSubject.Text);
                task.Status = task.TupleOfStatuses.TODO;
                task.Deadline = Calendar_SetDeadline.SelectionStart;
                task.CreateTask(task);
            }

            catch (ArgumentException ex)
            {

            }
        }

    }
}
