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
    public partial class StartLoad : Form
    {
        public StartLoad()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 5;
            progressBar1.Value = startPoint;
            if(progressBar1.Value==100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                this.Hide();
                StartForm start = new StartForm();
                start.Show();
            }
        }

        private void StartLoad_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
