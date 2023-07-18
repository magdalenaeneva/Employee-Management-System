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
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeData data=new ChangeData();
            data.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string id = empld.Text;
                //string employee;
                //StreamReader sr = new StreamReader("../../../text.txt");
               //List <string> employees=new List<string>();
               // while(sr.EndOfStream)
               // sr.Close();
               // employee = employees[employees.Count - 1];
               // info.Text = employee;
               foreach(string line in File.ReadLines("../../../text.txt"))
                {
                    string[] tokens = line.Split(' ');
                    if (tokens[0]==id)
                    {
                        info.Text = line;
                        break;
                    }
                }
 
            }
            catch
            {
                MessageBox.Show($"There is no data to show! {Environment.NewLine} Please insert some employees!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void remove_Click(object sender, EventArgs e)
        {
            string id = empld.Text;
            string deletedEmployee=string.Empty;
            foreach (string line in File.ReadLines("../../../text.txt"))
            {
                string[]tokens=line.Split(' ');
                if (tokens[0] == id)
                {
                    deletedEmployee=line;
                    break;
                }
            }
            List<string> linesList = File.ReadAllLines("../../../text.txt").ToList();
            int counter=0;
            foreach (string line in linesList)
            {
                string[] tokens = line.Split(' ');
                if (tokens[0] == id)
                {
                    break;
                }
                counter++;
            }
            if(linesList.Count>0)
            {
                linesList.RemoveAt(counter);

                FileStream fsOverwrite = new FileStream("../../../text.txt", FileMode.Create);

                StreamWriter swOverwrite = new StreamWriter(fsOverwrite);
                using (swOverwrite)
                {
                    foreach (string line in linesList)
                    {
                        swOverwrite.WriteLine(line);
                    }
                }
                //File.Delete("../../../text.txt");
                //File.WriteAllLines(("../../../text.txt"), linesList.ToArray());
                string[] names=deletedEmployee.Split(' ');
                MessageBox.Show($"{names[1]} {names[2]} {names[3]} with ID {names[0]}{Environment.NewLine}was removed from the system!", "Successfully removed!");
            }
           
        }
    }
}
