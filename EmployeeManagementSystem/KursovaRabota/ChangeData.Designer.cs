namespace KursovaRabota
{
    partial class ChangeData
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.remove = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.report = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.dweToolStripMenuItem,
            this.add,
            this.remove,
            this.changeSalary,
            this.report});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(10, 30, 30, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(0, 30, 0, 30);
            this.menu.Size = new System.Drawing.Size(404, 945);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.homeToolStripMenuItem.Image = global::KursovaRabota.Properties.Resources.home_removebg_preview;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 30);
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(403, 112);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // dweToolStripMenuItem
            // 
            this.dweToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dweToolStripMenuItem.Name = "dweToolStripMenuItem";
            this.dweToolStripMenuItem.Size = new System.Drawing.Size(403, 4);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Image = global::KursovaRabota.Properties.Resources.add_removebg_preview;
            this.add.Name = "add";
            this.add.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.add.Padding = new System.Windows.Forms.Padding(8, 0, 8, 30);
            this.add.Size = new System.Drawing.Size(403, 112);
            this.add.Text = "Add Employee";
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.Color.White;
            this.remove.Image = global::KursovaRabota.Properties.Resources.remove_removebg_preview;
            this.remove.Name = "remove";
            this.remove.Padding = new System.Windows.Forms.Padding(8, 0, 8, 30);
            this.remove.Size = new System.Drawing.Size(403, 112);
            this.remove.Text = "Remove By ID";
            this.remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // changeSalary
            // 
            this.changeSalary.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSalary.ForeColor = System.Drawing.Color.White;
            this.changeSalary.Image = global::KursovaRabota.Properties.Resources.money_removebg_preview;
            this.changeSalary.Name = "changeSalary";
            this.changeSalary.Padding = new System.Windows.Forms.Padding(8, 0, 8, 20);
            this.changeSalary.Size = new System.Drawing.Size(403, 102);
            this.changeSalary.Text = "Change Emp Salary";
            this.changeSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.changeSalary.Click += new System.EventHandler(this.changeSalary_Click);
            // 
            // report
            // 
            this.report.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.White;
            this.report.Image = global::KursovaRabota.Properties.Resources.report_removebg_preview;
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(8, 0, 8, 30);
            this.report.Size = new System.Drawing.Size(403, 112);
            this.report.Text = "Report";
            this.report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.SystemColors.Highlight;
            this.close.Image = global::KursovaRabota.Properties.Resources.exitWhite_removebg_preview1;
            this.close.Location = new System.Drawing.Point(962, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(61, 53);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ChangeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KursovaRabota.Properties.Resources.Happy_Workforce1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1035, 945);
            this.Controls.Add(this.close);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "ChangeData";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeData";
            this.Load += new System.EventHandler(this.ChangeData_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem dweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem remove;
        private System.Windows.Forms.ToolStripMenuItem changeSalary;
        private System.Windows.Forms.ToolStripMenuItem report;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.PictureBox close;
    }
}