using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDAppProject.Forms
{
    public partial class Form_LoggedIn : Form
    {
        public Form_LoggedIn()
        {
            InitializeComponent();
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

        }
    }
}
