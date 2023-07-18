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
    public partial class StartForm : Form
    {
        
      
        public StartForm()
        {
            InitializeComponent();
        }

        private void company_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.Show();
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

        private void infoAdmin_Click(object sender, EventArgs e)
        {
           AdminInfo adminInfo = new AdminInfo();
            adminInfo.Show();
            this.Hide();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AdminInfo adminInfo = new AdminInfo();
            adminInfo.Show();
            this.Hide();
        }

        private void changesPhoto_Click(object sender, EventArgs e)
        {
            ChangeData change = new ChangeData();
            change.Show();
            this.Hide();
        }

        private void changesLabel_Click(object sender, EventArgs e)
        {
            ChangeData change = new ChangeData();
            change.Show();
            this.Hide ();
        }

        private void AddEmployeePic_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee();
           add.Show();
            this.Hide();
        }
    }
}
