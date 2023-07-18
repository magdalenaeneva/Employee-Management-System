namespace KursovaRabota
{
    partial class StartLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeeSystem = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.developed = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeSystem
            // 
            this.employeeSystem.AutoSize = true;
            this.employeeSystem.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSystem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.employeeSystem.Location = new System.Drawing.Point(30, 59);
            this.employeeSystem.Name = "employeeSystem";
            this.employeeSystem.Size = new System.Drawing.Size(942, 66);
            this.employeeSystem.TabIndex = 4;
            this.employeeSystem.Text = "EMPLOYEE MANAGMENT SYSTEM";
            // 
            // progressBar1
            // 
            this.progressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.progressBar1.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar1.Location = new System.Drawing.Point(58, 607);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(896, 65);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // developed
            // 
            this.developed.AutoSize = true;
            this.developed.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.developed.Location = new System.Drawing.Point(263, 796);
            this.developed.Name = "developed";
            this.developed.Size = new System.Drawing.Size(475, 34);
            this.developed.TabIndex = 6;
            this.developed.Text = "Developed by Magdalena Eneva";
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progress.Location = new System.Drawing.Point(414, 708);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(133, 66);
            this.progress.TabIndex = 7;
            this.progress.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KursovaRabota.Properties.Resources.employeesStart_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(176, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 863);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.developed);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.employeeSystem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMangment";
            this.Load += new System.EventHandler(this.StartLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label employeeSystem;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label developed;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Timer timer1;
    }
}

