namespace KursovaRabota
{
    partial class StartForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            this.homePicture = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.company = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.changesLabel = new System.Windows.Forms.Label();
            this.addEmployee = new System.Windows.Forms.Label();
            this.infoAdmin = new System.Windows.Forms.PictureBox();
            this.changesPhoto = new System.Windows.Forms.PictureBox();
            this.AddEmployeePic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changesPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmployeePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ExitPicture);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.homePicture);
            this.panel1.Controls.Add(this.home);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 142);
            this.panel1.TabIndex = 0;
            // 
            // ExitPicture
            // 
            this.ExitPicture.Image = global::KursovaRabota.Properties.Resources.exitBlue_removebg_preview;
            this.ExitPicture.Location = new System.Drawing.Point(1075, 28);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(104, 86);
            this.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPicture.TabIndex = 11;
            this.ExitPicture.TabStop = false;
            this.ExitPicture.Click += new System.EventHandler(this.ExitPicture_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.exit.Location = new System.Drawing.Point(1199, 38);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(119, 60);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // homePicture
            // 
            this.homePicture.Image = global::KursovaRabota.Properties.Resources.homeIcon_removebg_preview;
            this.homePicture.Location = new System.Drawing.Point(35, 28);
            this.homePicture.Name = "homePicture";
            this.homePicture.Size = new System.Drawing.Size(98, 81);
            this.homePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePicture.TabIndex = 9;
            this.homePicture.TabStop = false;
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.SteelBlue;
            this.home.Location = new System.Drawing.Point(139, 38);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(170, 60);
            this.home.TabIndex = 8;
            this.home.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.company);
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1425, 180);
            this.panel2.TabIndex = 12;
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.Color.SteelBlue;
            this.company.Location = new System.Drawing.Point(980, 15);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(357, 40);
            this.company.TabIndex = 12;
            this.company.Text = "© Magdalena Eneva";
            this.company.Click += new System.EventHandler(this.company_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(51, 437);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(333, 66);
            this.Admin.TabIndex = 12;
            this.Admin.Text = "Admin Info";
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // changesLabel
            // 
            this.changesLabel.AutoSize = true;
            this.changesLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changesLabel.ForeColor = System.Drawing.Color.White;
            this.changesLabel.Location = new System.Drawing.Point(480, 437);
            this.changesLabel.Name = "changesLabel";
            this.changesLabel.Size = new System.Drawing.Size(378, 66);
            this.changesLabel.TabIndex = 14;
            this.changesLabel.Text = "Change data";
            this.changesLabel.Click += new System.EventHandler(this.changesLabel_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.AutoSize = true;
            this.addEmployee.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.Color.White;
            this.addEmployee.Location = new System.Drawing.Point(915, 437);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(422, 66);
            this.addEmployee.TabIndex = 16;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // infoAdmin
            // 
            this.infoAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.infoAdmin.Image = global::KursovaRabota.Properties.Resources.info_removebg_preview;
            this.infoAdmin.Location = new System.Drawing.Point(96, 229);
            this.infoAdmin.Name = "infoAdmin";
            this.infoAdmin.Size = new System.Drawing.Size(240, 170);
            this.infoAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoAdmin.TabIndex = 15;
            this.infoAdmin.TabStop = false;
            this.infoAdmin.Click += new System.EventHandler(this.infoAdmin_Click);
            // 
            // changesPhoto
            // 
            this.changesPhoto.BackColor = System.Drawing.SystemColors.Highlight;
            this.changesPhoto.Image = global::KursovaRabota.Properties.Resources.report_removebg_preview;
            this.changesPhoto.Location = new System.Drawing.Point(560, 229);
            this.changesPhoto.Name = "changesPhoto";
            this.changesPhoto.Size = new System.Drawing.Size(211, 186);
            this.changesPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.changesPhoto.TabIndex = 13;
            this.changesPhoto.TabStop = false;
            this.changesPhoto.Click += new System.EventHandler(this.changesPhoto_Click);
            // 
            // AddEmployeePic
            // 
            this.AddEmployeePic.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddEmployeePic.Image = global::KursovaRabota.Properties.Resources._5253047_middle_removebg_preview;
            this.AddEmployeePic.Location = new System.Drawing.Point(1000, 229);
            this.AddEmployeePic.Name = "AddEmployeePic";
            this.AddEmployeePic.Size = new System.Drawing.Size(247, 188);
            this.AddEmployeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddEmployeePic.TabIndex = 12;
            this.AddEmployeePic.TabStop = false;
            this.AddEmployeePic.Click += new System.EventHandler(this.AddEmployeePic_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1363, 647);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.infoAdmin);
            this.Controls.Add(this.changesLabel);
            this.Controls.Add(this.changesPhoto);
            this.Controls.Add(this.AddEmployeePic);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changesPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEmployeePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox homePicture;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.PictureBox AddEmployeePic;
        private System.Windows.Forms.PictureBox changesPhoto;
        private System.Windows.Forms.Label changesLabel;
        private System.Windows.Forms.PictureBox infoAdmin;
        private System.Windows.Forms.Label addEmployee;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.PictureBox ExitPicture;
    }
}