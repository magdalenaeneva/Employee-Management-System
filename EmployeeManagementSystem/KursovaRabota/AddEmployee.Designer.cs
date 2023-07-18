namespace KursovaRabota
{
    partial class AddEmployee
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
            this.exit = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addEmp = new System.Windows.Forms.Label();
            this.addEmpl = new System.Windows.Forms.PictureBox();
            this.fNME = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.sur = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Add = new System.Windows.Forms.Button();
            this.lastName = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.empID = new System.Windows.Forms.TextBox();
            this.prof = new System.Windows.Forms.Label();
            this.proffesion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departments = new System.Windows.Forms.ComboBox();
            this.salry = new System.Windows.Forms.Label();
            this.emplSalary = new System.Windows.Forms.TextBox();
            this.receiptDate = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmpl)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.addEmp);
            this.panel1.Controls.Add(this.addEmpl);
            this.panel1.Location = new System.Drawing.Point(-10, -28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 179);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Image = global::KursovaRabota.Properties.Resources.exitWhite_removebg_preview;
            this.exit.Location = new System.Drawing.Point(1212, 40);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(66, 46);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 13;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(847, 77);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(153, 53);
            this.home.TabIndex = 12;
            this.home.Text = "Home";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KursovaRabota.Properties.Resources.home_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(1020, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addEmp
            // 
            this.addEmp.AutoSize = true;
            this.addEmp.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmp.ForeColor = System.Drawing.Color.White;
            this.addEmp.Location = new System.Drawing.Point(173, 84);
            this.addEmp.Name = "addEmp";
            this.addEmp.Size = new System.Drawing.Size(296, 46);
            this.addEmp.TabIndex = 9;
            this.addEmp.Text = "Add Employee";
            // 
            // addEmpl
            // 
            this.addEmpl.Image = global::KursovaRabota.Properties.Resources.addEmployee_removebg_preview;
            this.addEmpl.Location = new System.Drawing.Point(45, 58);
            this.addEmpl.Name = "addEmpl";
            this.addEmpl.Size = new System.Drawing.Size(108, 95);
            this.addEmpl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmpl.TabIndex = 0;
            this.addEmpl.TabStop = false;
            // 
            // fNME
            // 
            this.fNME.AutoSize = true;
            this.fNME.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNME.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fNME.Location = new System.Drawing.Point(39, 313);
            this.fNME.Name = "fNME";
            this.fNME.Size = new System.Drawing.Size(289, 53);
            this.fNME.TabIndex = 14;
            this.fNME.Text = "First Name:";
            // 
            // fName
            // 
            this.fName.BackColor = System.Drawing.Color.White;
            this.fName.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fName.Location = new System.Drawing.Point(393, 313);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(331, 60);
            this.fName.TabIndex = 15;
            // 
            // sur
            // 
            this.sur.AutoSize = true;
            this.sur.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sur.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sur.Location = new System.Drawing.Point(45, 438);
            this.sur.Name = "sur";
            this.sur.Size = new System.Drawing.Size(246, 53);
            this.sur.TabIndex = 16;
            this.sur.Text = "Surname:";
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.White;
            this.surname.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.surname.Location = new System.Drawing.Point(393, 431);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(331, 60);
            this.surname.TabIndex = 17;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LName.Location = new System.Drawing.Point(39, 543);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(283, 53);
            this.LName.TabIndex = 18;
            this.LName.Text = "Last Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.Add);
            this.panel2.Location = new System.Drawing.Point(-40, 790);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1391, 177);
            this.panel2.TabIndex = 14;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.Highlight;
            this.Add.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(608, 24);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(177, 87);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.White;
            this.lastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lastName.Location = new System.Drawing.Point(393, 536);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(331, 60);
            this.lastName.TabIndex = 19;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ID.Location = new System.Drawing.Point(39, 206);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(332, 53);
            this.ID.TabIndex = 20;
            this.ID.Text = "Employee ID:";
            // 
            // empID
            // 
            this.empID.BackColor = System.Drawing.Color.White;
            this.empID.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.empID.Location = new System.Drawing.Point(393, 199);
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(331, 60);
            this.empID.TabIndex = 21;
            // 
            // prof
            // 
            this.prof.AutoSize = true;
            this.prof.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prof.Location = new System.Drawing.Point(45, 666);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(283, 53);
            this.prof.TabIndex = 22;
            this.prof.Text = "Proffesion: ";
            // 
            // proffesion
            // 
            this.proffesion.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proffesion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.proffesion.FormattingEnabled = true;
            this.proffesion.Items.AddRange(new object[] {
            "ProjectManager",
            "DataScientist",
            "Digitalskills",
            "WebDeveloper",
            "UXDesigner"});
            this.proffesion.Location = new System.Drawing.Point(393, 658);
            this.proffesion.Name = "proffesion";
            this.proffesion.Size = new System.Drawing.Size(331, 61);
            this.proffesion.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(862, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 53);
            this.label1.TabIndex = 24;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(837, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 53);
            this.label2.TabIndex = 25;
            this.label2.Text = "Department:";
            // 
            // departments
            // 
            this.departments.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departments.ForeColor = System.Drawing.SystemColors.Highlight;
            this.departments.FormattingEnabled = true;
            this.departments.Items.AddRange(new object[] {
            "Marketing",
            "Sales",
            "Engineering",
            "Support",
            "Operations",
            "Finance"});
            this.departments.Location = new System.Drawing.Point(819, 306);
            this.departments.Name = "departments";
            this.departments.Size = new System.Drawing.Size(331, 61);
            this.departments.TabIndex = 26;
            // 
            // salry
            // 
            this.salry.AutoSize = true;
            this.salry.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.salry.Location = new System.Drawing.Point(792, 409);
            this.salry.Name = "salry";
            this.salry.Size = new System.Drawing.Size(421, 53);
            this.salry.TabIndex = 27;
            this.salry.Text = "Employee Salary:";
            // 
            // emplSalary
            // 
            this.emplSalary.BackColor = System.Drawing.Color.White;
            this.emplSalary.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emplSalary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.emplSalary.Location = new System.Drawing.Point(830, 491);
            this.emplSalary.Name = "emplSalary";
            this.emplSalary.Size = new System.Drawing.Size(331, 60);
            this.emplSalary.TabIndex = 28;
            // 
            // receiptDate
            // 
            this.receiptDate.AutoSize = true;
            this.receiptDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.receiptDate.Location = new System.Drawing.Point(792, 587);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(392, 53);
            this.receiptDate.TabIndex = 29;
            this.receiptDate.Text = "Date of Receipt:";
            // 
            // date
            // 
            this.date.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.date.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.date.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(830, 671);
            this.date.MaxDate = new System.DateTime(2023, 5, 16, 0, 29, 10, 0);
            this.date.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(331, 60);
            this.date.TabIndex = 30;
            this.date.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 959);
            this.Controls.Add(this.date);
            this.Controls.Add(this.receiptDate);
            this.Controls.Add(this.emplSalary);
            this.Controls.Add(this.salry);
            this.Controls.Add(this.departments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proffesion);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.sur);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.fNME);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmpl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox addEmpl;
        private System.Windows.Forms.Label addEmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label home;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label fNME;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label sur;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.Label prof;
        private System.Windows.Forms.ComboBox proffesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departments;
        private System.Windows.Forms.Label salry;
        private System.Windows.Forms.TextBox emplSalary;
        private System.Windows.Forms.Label receiptDate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button Add;
    }
}