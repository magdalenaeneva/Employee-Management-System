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
    public partial class ChangeData : Form
    {
        public ChangeData()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ChangeData_Load(object sender, EventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void report_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("../../../text.txt");
               string emptyFile=sr.ReadToEnd();
                sr.Close();
                if(emptyFile=="")
                {
                    MessageBox.Show($"There is no data to show! {Environment.NewLine} Please insert some employees!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AddEmployee add = new AddEmployee();
                    add.Show();
                    this.Hide();
                }
                else
                {
                    Report report = new Report();
                    report.Show();
                    this.Close();
                }
              
            }
            catch
            {
                MessageBox.Show($"There is no data to show! {Environment.NewLine} Please insert some employees!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddEmployee add = new AddEmployee();
                add.Show();
                this.Hide();

            }
        }

        private void changeSalary_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("../../../text.txt");
                string emptyFile = sr.ReadToEnd();
                sr.Close();
                if (emptyFile == "")
                {
                    MessageBox.Show($"There is no data to show! {Environment.NewLine} Please insert some employees!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AddEmployee add = new AddEmployee();
                    add.Show();
                    this.Hide();
                }
                else
                {
                    ChangeSalary change = new ChangeSalary();
                    change.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show($"There is no data to show! {Environment.NewLine} Please insert some employees!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddEmployee add = new AddEmployee();
                add.Show();
                this.Hide();
            }
           
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            start.Show();
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.ShowDialog();
            this.Close();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("../../../text.txt");
                string emptyFile = sr.ReadToEnd();
                sr.Close();
                if (emptyFile == "")
                {
                    MessageBox.Show($"There is no data to show! {Environment.NewLine} Please insert some employees!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AddEmployee add = new AddEmployee();
                    add.Show();
                    this.Hide();
                }
                else
                {
                    RemoveEmployee remove = new RemoveEmployee();
                    remove.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show($"There is no data to show! {Environment.NewLine} Please insert some employees!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddEmployee add = new AddEmployee();
                add.Show();
                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
