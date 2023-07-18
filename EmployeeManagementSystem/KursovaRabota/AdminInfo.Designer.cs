namespace KursovaRabota
{
    partial class AdminInfo
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
            this.Admin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ExitPicture = new System.Windows.Forms.PictureBox();
            this.homePicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(59, 121);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(775, 66);
            this.Admin.TabIndex = 13;
            this.Admin.Text = "Admin System Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ExitPicture);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.homePicture);
            this.panel1.Controls.Add(this.home);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 98);
            this.panel1.TabIndex = 14;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.exit.Location = new System.Drawing.Point(800, 23);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 53);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.SteelBlue;
            this.home.Location = new System.Drawing.Point(120, 23);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(153, 53);
            this.home.TabIndex = 8;
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.ForeColor = System.Drawing.Color.White;
            this.fName.Location = new System.Drawing.Point(319, 229);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(250, 46);
            this.fName.TabIndex = 15;
            this.fName.Text = "First Name:";
            // 
            // firstName
            // 
            this.firstName.AllowDrop = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.firstName.Location = new System.Drawing.Point(613, 223);
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Size = new System.Drawing.Size(261, 56);
            this.firstName.TabIndex = 16;
            this.firstName.Text = "Magdalena";
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Location = new System.Drawing.Point(324, 324);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(212, 46);
            this.surname.TabIndex = 17;
            this.surname.Text = "Surname:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.ForeColor = System.Drawing.Color.White;
            this.lName.Location = new System.Drawing.Point(324, 418);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(245, 46);
            this.lName.TabIndex = 19;
            this.lName.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.AllowDrop = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lastName.Location = new System.Drawing.Point(613, 412);
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Size = new System.Drawing.Size(261, 56);
            this.lastName.TabIndex = 20;
            this.lastName.Text = "Eneva";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.White;
            this.Gender.Location = new System.Drawing.Point(444, 619);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(179, 46);
            this.Gender.TabIndex = 24;
            this.Gender.Text = "Gender:";
            // 
            // female
            // 
            this.female.AllowDrop = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.SystemColors.Highlight;
            this.female.Location = new System.Drawing.Point(644, 609);
            this.female.Name = "female";
            this.female.ReadOnly = true;
            this.female.Size = new System.Drawing.Size(230, 56);
            this.female.TabIndex = 25;
            this.female.Text = "Female";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.White;
            this.age.Location = new System.Drawing.Point(324, 510);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(111, 46);
            this.age.TabIndex = 26;
            this.age.Text = "Age:";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(332, 577);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(71, 56);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "20";
            // 
            // IdTextBox
            // 
            this.IdTextBox.AllowDrop = true;
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.IdTextBox.Location = new System.Drawing.Point(644, 515);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(230, 56);
            this.IdTextBox.TabIndex = 23;
            this.IdTextBox.Text = "10.07.2003";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(499, 521);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(124, 46);
            this.ID.TabIndex = 22;
            this.ID.Text = "DOB:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(-3, 870);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 99);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 46);
            this.label1.TabIndex = 29;
            this.label1.Text = "Education: ";
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox2.Location = new System.Drawing.Point(49, 769);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(217, 56);
            this.textBox2.TabIndex = 30;
            this.textBox2.Text = "Secondary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(678, 697);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 46);
            this.label3.TabIndex = 33;
            this.label3.Text = "Phone: ";
            // 
            // textBox4
            // 
            this.textBox4.AllowDrop = true;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox4.Location = new System.Drawing.Point(634, 769);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(253, 56);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "098765...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(388, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 46);
            this.label4.TabIndex = 35;
            this.label4.Text = "City:";
            // 
            // textBox5
            // 
            this.textBox5.AllowDrop = true;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox5.Location = new System.Drawing.Point(332, 769);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(240, 56);
            this.textBox5.TabIndex = 36;
            this.textBox5.Text = "Plovdiv";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.AllowDrop = true;
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.surnameTextBox.Location = new System.Drawing.Point(613, 318);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(261, 56);
            this.surnameTextBox.TabIndex = 18;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.surnameTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KursovaRabota.Properties.Resources.az;
            this.pictureBox1.Location = new System.Drawing.Point(24, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ExitPicture
            // 
            this.ExitPicture.Image = global::KursovaRabota.Properties.Resources.exitBlue_removebg_preview;
            this.ExitPicture.Location = new System.Drawing.Point(716, 14);
            this.ExitPicture.Name = "ExitPicture";
            this.ExitPicture.Size = new System.Drawing.Size(90, 73);
            this.ExitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPicture.TabIndex = 11;
            this.ExitPicture.TabStop = false;
            this.ExitPicture.Click += new System.EventHandler(this.ExitPicture_Click);
            // 
            // homePicture
            // 
            this.homePicture.Image = global::KursovaRabota.Properties.Resources.homeIcon_removebg_preview;
            this.homePicture.Location = new System.Drawing.Point(19, 14);
            this.homePicture.Name = "homePicture";
            this.homePicture.Size = new System.Drawing.Size(95, 69);
            this.homePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePicture.TabIndex = 9;
            this.homePicture.TabStop = false;
            this.homePicture.Click += new System.EventHandler(this.homePicture_Click);
            // 
            // AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(933, 950);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.age);
            this.Controls.Add(this.female);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Admin);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminInfo";
            this.Load += new System.EventHandler(this.AdminInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ExitPicture;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.PictureBox homePicture;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox female;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox surnameTextBox;
    }
}