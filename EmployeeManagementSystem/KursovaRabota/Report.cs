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
    public partial class Report : Form
    {

        ChangeData changeData = new ChangeData();
        public Report()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("../../../text.txt");
            using(sr)
            {
                richTextBox1.Text=sr.ReadToEnd();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            changeData.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
