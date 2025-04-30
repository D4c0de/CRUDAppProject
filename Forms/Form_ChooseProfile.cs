using CRUDAppProject.CS.Base;
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
    public partial class Form_ChooseProfile : Form
    {
        public Form_ChooseProfile()
        {
            InitializeComponent();
            Base_SemestrProfile.LoadAllProfilesFromFile(ComboBox_ProfileName);
        }

        private void Form_ChooseProfile_Load(object sender, EventArgs e)
        {

        }

        private void Button_LogIn_Click(object sender, EventArgs e)
        {

        }

        private void Button_ExitProfileChoosing_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_Logging Screen_Logging = new Form_Logging();
            Screen_Logging.Show();
            
        }
    }
}
