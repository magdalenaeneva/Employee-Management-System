using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaRabota
{
    public partial class AdminInfo : Form
    {
       
        public AdminInfo()
        {
            InitializeComponent();
        }

        private void AdminInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void homePicture_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
