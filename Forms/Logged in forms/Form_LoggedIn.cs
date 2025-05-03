using CRUDAppProject.CS.Base;
using CRUDAppProject.CS.Side;
using CRUDAppProject.CS.Tasks;
using CRUDAppProject.Forms.Logged_in_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAppProject.Forms
{
    public partial class Form_LoggedIn : Form
    {
        public Form_LoggedIn()
        {
            InitializeComponent();
            Base_AppState.CardCount = 0;


            string json = File.ReadAllText(Base_AppState.ChosenProfileFilePath);

            var options = new JsonSerializerOptions
            {
                Converters = { new TaskConverter() },
                PropertyNameCaseInsensitive = true
            };

            var document = JsonSerializer.Deserialize<RootObject>(json, options);

            foreach (var task in document.Tasks)
            {
                task.ShowTaskCard(Panel_TaskCardsPanel);
            }

        }

        private void Button_LogOut_Click(object sender, EventArgs e)
        {
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();
            this.Close();
            this.Hide();           
        }

        private void Button_CreateNewTask_Click(object sender, EventArgs e)
        {
            Form_CreateTask Screen_CreateTask = new Form_CreateTask();
            Screen_CreateTask.Show();
            this.Hide();
            this.Close();            
        }
    }
}
