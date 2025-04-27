using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUDAppProject.Forms
{
    public partial class Form_Logging 
    {
        public Form_Logging()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_CreateProfile Screen_CreateProfile = new Form_CreateProfile();
            Screen_CreateProfile.Show();
        }

        private void Button_DeleteProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Form_DeleteProfile Screen_DeleteProfile = new Form_DeleteProfile();
            Screen_DeleteProfile.Show();
        }
    }
}
