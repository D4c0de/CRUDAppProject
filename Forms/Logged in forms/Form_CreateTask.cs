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
    public partial class Form_CreateTask : Form
    {
        public Form_CreateTask()
        {                          
            InitializeComponent();
            foreach (string task in Base_Task.ListOfTaskTypes)
            {
                Listbox_TaskTypes.Items.Add(task);
            }
        }

        private void ChooseTaskType()
        {
            string taskType = Side_Format.CapitalizeString(Listbox_TaskTypes.Text);

            var taskTypeMap = new Dictionary<string, Action>
            {
                { Base_Task.ListOfTaskTypes[0], () => new Task_Exercise().TaskCreator() },
                { Base_Task.ListOfTaskTypes[1], () => new Task_Proj().TaskCreator() },
                { Base_Task.ListOfTaskTypes[2], () => new Task_Exam().TaskCreator() }
            };

            if (Base_Task.ListOfTaskTypes.Contains(Listbox_TaskTypes.Text) && taskTypeMap.TryGetValue(taskType, out Action createTask))
            {
                createTask();
                this.Hide();
                this.Close();
            }
            else
            {
                throw new ArgumentException("Nieznany rodzaj zadania! Wybierz poprawny z listy!", "TaskTypeNotRecognized");
            }
        }


        private void Button_EnterTaskCreator_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseTaskType();
            }

            catch(ArgumentException ex)
            {
                if(ex.ParamName == "TaskTypeNotRecognized")
                {
                    MessageBox.Show("Nieznany rodzaj zadania! Wybierz poprawny z listy!", "Tworzenie zadania nie powiodło się.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }
    }
}
