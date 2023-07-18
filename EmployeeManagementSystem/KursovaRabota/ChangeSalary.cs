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
    public partial class ChangeSalary : Form
    {
        public ChangeSalary()
        {
            InitializeComponent();
        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeData data = new ChangeData();
            data.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {

            try
            {
                string id = searchEmp.Text;
                foreach (string line in File.ReadLines("../../../text.txt"))
                {
                    string[] tokens = line.Split(' ');
                    if (tokens[0] == id)
                    {
                        ID.Visible = true;
                        ID.Text = $"ID: {tokens[0]}";
                        name.Visible = true;
                        name.Text = $"Full name:{Environment.NewLine} {tokens[1]} {tokens[2]} {tokens[3]}";
                        prof.Visible = true;
                        prof.Text = $"Proffesion:{Environment.NewLine} {tokens[4]}";
                        dep.Visible = true;
                        dep.Text = $"Department:{Environment.NewLine} {tokens[5]}";
                        salry.Visible = true;
                        salry.Text = $"Salary: {tokens[6]}";
                        receiptDate.Visible = true;
                        receiptDate.Text = $"Date of reciept:{Environment.NewLine} {tokens[7]}";
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show($"There is no data to show! {Environment.NewLine} Please insert some employees!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newSalary_TextChanged(object sender, EventArgs e)
        {
        }

        private void searchEmp_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            string seachByID = searchEmp.Text;
            string salary = newSalary.Text;
            string updatedSalaryEmployee = string.Empty;
            string oldSalary=string.Empty;
            foreach (string line in File.ReadLines("../../../text.txt"))
            {
                string[] tokens = line.Split(' ');
                oldSalary = tokens[6];
                if (tokens[0] == seachByID)
                {
                    tokens[6] = salary;
                    updatedSalaryEmployee = String.Join(" ", tokens);
                    break;
                }
            }
            List<string> linesList = File.ReadAllLines("../../../text.txt").ToList();
            int counter = 0;
            foreach (string line in linesList)
            {
                string[] tokens = line.Split(' ');
                if (tokens[0] == seachByID)
                {
                    break;
                }
                counter++;
            }
            if (linesList.Count > 0)
            {
                linesList.RemoveAt(counter);
                linesList.Insert(counter, updatedSalaryEmployee);
                FileStream fsOverwrite = new FileStream("../../../text.txt", FileMode.Create);

                StreamWriter swOverwrite = new StreamWriter(fsOverwrite);
                using (swOverwrite)
                {
                    foreach (string line in linesList)
                    {
                        swOverwrite.WriteLine(line);
                    }
                }
                
                string[] names = updatedSalaryEmployee.Split(' ');
                MessageBox.Show($"Successfully updated salary of {oldSalary} lv. to {names[6]} lv.{Environment.NewLine} to person {names[1]} {names[2]} {names[3]}");
            }
        }
    }
}
