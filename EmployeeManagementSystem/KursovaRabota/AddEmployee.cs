using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaRabota
{
    public partial class AddEmployee : Form
    {
        StartForm startForm=new StartForm();
      //  StringBuilder sb = new StringBuilder();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(empID.Text=="" || fName.Text == "" || surname.Text == "" || lastName.Text == "" || proffesion.SelectedIndex==-1 || departments.SelectedIndex==-1 || emplSalary.Text == "") 
            {
              MessageBox.Show("Please fill all fields!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                StreamWriter sw = new StreamWriter("../../../text.txt",true);

                using (sw)
                {
                    sw.WriteLine($"{empID.Text} {fName.Text} {surname.Text} {lastName.Text} {proffesion.SelectedItem} {departments.SelectedItem} {emplSalary.Text} {date.Text}");
                }

                //sb.AppendLine($"{empID.Text} {fName.Text} {surname.Text} {lastName.Text} {proffesion.SelectedItem} {departments.SelectedItem} {emplSalary.Text} {date.Text}");

                MessageBox.Show($"Successfully added Employee {Environment.NewLine}{fName.Text} {surname.Text} {lastName.Text}!","Success!");
            }
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startForm.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            startForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
