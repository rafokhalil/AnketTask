
namespace WindowsFormsAppLesson3Part2
{
    partial class Anket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anket));
            this.AnketGroupBox = new System.Windows.Forms.GroupBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ChangedBtn = new System.Windows.Forms.Button();
            this.DateLbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NumberLbl = new System.Windows.Forms.Label();
            this.PhoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.MailLbl = new System.Windows.Forms.Label();
            this.MailTxtBox = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.SurnameTxtBox = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.FileNameTxtBox = new System.Windows.Forms.TextBox();
            this.FileNameLbl = new System.Windows.Forms.Label();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.AnketGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnketGroupBox
            // 
            this.AnketGroupBox.BackColor = System.Drawing.Color.IndianRed;
            this.AnketGroupBox.Controls.Add(this.AddBtn);
            this.AnketGroupBox.Controls.Add(this.ChangedBtn);
            this.AnketGroupBox.Controls.Add(this.DateLbl);
            this.AnketGroupBox.Controls.Add(this.dateTimePicker1);
            this.AnketGroupBox.Controls.Add(this.NumberLbl);
            this.AnketGroupBox.Controls.Add(this.PhoneNumberTxtBox);
            this.AnketGroupBox.Controls.Add(this.MailLbl);
            this.AnketGroupBox.Controls.Add(this.MailTxtBox);
            this.AnketGroupBox.Controls.Add(this.SurnameLbl);
            this.AnketGroupBox.Controls.Add(this.SurnameTxtBox);
            this.AnketGroupBox.Controls.Add(this.NameLbl);
            this.AnketGroupBox.Controls.Add(this.NameTxtBox);
            this.AnketGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnketGroupBox.Location = new System.Drawing.Point(33, 12);
            this.AnketGroupBox.Name = "AnketGroupBox";
            this.AnketGroupBox.Size = new System.Drawing.Size(505, 580);
            this.AnketGroupBox.TabIndex = 0;
            this.AnketGroupBox.TabStop = false;
            this.AnketGroupBox.Text = "Anket";
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.Location = new System.Drawing.Point(152, 347);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(125, 41);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ChangedBtn
            // 
            this.ChangedBtn.AutoSize = true;
            this.ChangedBtn.Enabled = false;
            this.ChangedBtn.Location = new System.Drawing.Point(152, 419);
            this.ChangedBtn.Name = "ChangedBtn";
            this.ChangedBtn.Size = new System.Drawing.Size(125, 41);
            this.ChangedBtn.TabIndex = 10;
            this.ChangedBtn.Text = "Change";
            this.ChangedBtn.UseVisualStyleBackColor = true;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLbl.Location = new System.Drawing.Point(21, 277);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(85, 24);
            this.DateLbl.TabIndex = 9;
            this.DateLbl.Text = "BirthDate";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 273);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 38);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // NumberLbl
            // 
            this.NumberLbl.AutoSize = true;
            this.NumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLbl.Location = new System.Drawing.Point(19, 220);
            this.NumberLbl.Name = "NumberLbl";
            this.NumberLbl.Size = new System.Drawing.Size(127, 20);
            this.NumberLbl.TabIndex = 7;
            this.NumberLbl.Text = "Phone Number";
            // 
            // PhoneNumberTxtBox
            // 
            this.PhoneNumberTxtBox.Location = new System.Drawing.Point(152, 220);
            this.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            this.PhoneNumberTxtBox.Size = new System.Drawing.Size(182, 38);
            this.PhoneNumberTxtBox.TabIndex = 6;
            // 
            // MailLbl
            // 
            this.MailLbl.AutoSize = true;
            this.MailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MailLbl.Location = new System.Drawing.Point(19, 166);
            this.MailLbl.Name = "MailLbl";
            this.MailLbl.Size = new System.Drawing.Size(44, 24);
            this.MailLbl.TabIndex = 5;
            this.MailLbl.Text = "Mail";
            this.MailLbl.Click += new System.EventHandler(this.MailLbl_Click);
            // 
            // MailTxtBox
            // 
            this.MailTxtBox.Location = new System.Drawing.Point(152, 156);
            this.MailTxtBox.Name = "MailTxtBox";
            this.MailTxtBox.Size = new System.Drawing.Size(182, 38);
            this.MailTxtBox.TabIndex = 4;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLbl.Location = new System.Drawing.Point(19, 111);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(87, 24);
            this.SurnameLbl.TabIndex = 3;
            this.SurnameLbl.Text = "Surname";
            // 
            // SurnameTxtBox
            // 
            this.SurnameTxtBox.Location = new System.Drawing.Point(152, 101);
            this.SurnameTxtBox.Name = "SurnameTxtBox";
            this.SurnameTxtBox.Size = new System.Drawing.Size(182, 38);
            this.SurnameTxtBox.TabIndex = 2;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLbl.Location = new System.Drawing.Point(19, 56);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(61, 24);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(152, 46);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(182, 38);
            this.NameTxtBox.TabIndex = 0;
            // 
            // NamesListBox
            // 
            this.NamesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NamesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamesListBox.ForeColor = System.Drawing.Color.White;
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.ItemHeight = 31;
            this.NamesListBox.Location = new System.Drawing.Point(842, 57);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(236, 314);
            this.NamesListBox.TabIndex = 1;
            this.NamesListBox.SelectedIndexChanged += new System.EventHandler(this.NamesListBox_SelectedIndexChanged);
            // 
            // FileNameTxtBox
            // 
            this.FileNameTxtBox.Location = new System.Drawing.Point(896, 387);
            this.FileNameTxtBox.Name = "FileNameTxtBox";
            this.FileNameTxtBox.Size = new System.Drawing.Size(182, 20);
            this.FileNameTxtBox.TabIndex = 2;
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FileNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameLbl.Location = new System.Drawing.Point(775, 383);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(97, 24);
            this.FileNameLbl.TabIndex = 3;
            this.FileNameLbl.Text = "File Name";
            // 
            // LoadBtn
            // 
            this.LoadBtn.AutoSize = true;
            this.LoadBtn.Enabled = false;
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadBtn.Location = new System.Drawing.Point(779, 442);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(125, 41);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AutoSize = true;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(969, 442);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(125, 41);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2AnimateWindow1.Interval = 1000;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // Anket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::WindowsFormsAppLesson3Part2.Properties.Resources._193_1937235_page_6_ultra_hd_4k_nature_wallpapers_desktop;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.FileNameLbl);
            this.Controls.Add(this.FileNameTxtBox);
            this.Controls.Add(this.NamesListBox);
            this.Controls.Add(this.AnketGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Anket";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AnketGroupBox.ResumeLayout(false);
            this.AnketGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AnketGroupBox;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.TextBox SurnameTxtBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label MailLbl;
        private System.Windows.Forms.TextBox MailTxtBox;
        private System.Windows.Forms.Label NumberLbl;
        private System.Windows.Forms.TextBox PhoneNumberTxtBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ChangedBtn;
        private System.Windows.Forms.ListBox NamesListBox;
        private System.Windows.Forms.TextBox FileNameTxtBox;
        private System.Windows.Forms.Label FileNameLbl;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

