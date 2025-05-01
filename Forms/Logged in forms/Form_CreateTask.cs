using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Static;
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
            foreach (string task in Base_SemestrProfile.ListOfTaskTypes)
            {
                Listbox_TaskTypes.Items.Add(task);
            }
        }

        private void ChooseTaskType()
        {
            if (Base_SemestrProfile.ListOfTaskTypes.Contains(Listbox_TaskTypes.Text))
            {
                if (Side_Format.CapitalizeString(Listbox_TaskTypes.Text) == "Ćwiczenie")
                {

                }

                else if (Side_Format.CapitalizeString(Listbox_TaskTypes.Text) == "Projekt")
                {

                }

                else if (Side_Format.CapitalizeString(Listbox_TaskTypes.Text)  == "Egzamin")
                {

                }
            }

            else
                throw new ArgumentException("Nieznany rodzaj zadania! Wybierz poprwany z listy!", "TaskTypeNotRecognized");
        }


        private void Button_EnterTaskCreator_Click(object sender, EventArgs e)
        {

        }
    }
}
