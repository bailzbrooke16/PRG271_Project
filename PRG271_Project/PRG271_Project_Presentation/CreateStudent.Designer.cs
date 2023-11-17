namespace PRG271_Project_Presentation
{
    partial class CreateStudent
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
            menuStrip1 = new MenuStrip();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsToolStripMenuItem = new ToolStripMenuItem();
            createStudentToolStripMenuItem = new ToolStripMenuItem();
            linkModulesToolStripMenuItem = new ToolStripMenuItem();
            searchStudentToolStripMenuItem = new ToolStripMenuItem();
            modulesToolStripMenuItem = new ToolStripMenuItem();
            createModuleToolStripMenuItem = new ToolStripMenuItem();
            viewModulesToolStripMenuItem = new ToolStripMenuItem();
            searchModulesToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_name = new TextBox();
            txt_surname = new TextBox();
            txt_gender = new TextBox();
            dt_dob = new DateTimePicker();
            txt_phone = new TextBox();
            txt_address = new TextBox();
            Create = new Button();
            lbl_error = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, modulesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(885, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStudentsToolStripMenuItem, createStudentToolStripMenuItem, linkModulesToolStripMenuItem, searchStudentToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(127, 38);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // viewStudentsToolStripMenuItem
            // 
            viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            viewStudentsToolStripMenuItem.Size = new Size(308, 44);
            viewStudentsToolStripMenuItem.Text = "View Students";
            viewStudentsToolStripMenuItem.Click += viewStudentsToolStripMenuItem_Click;
            // 
            // createStudentToolStripMenuItem
            // 
            createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            createStudentToolStripMenuItem.Size = new Size(308, 44);
            createStudentToolStripMenuItem.Text = "Create Student";
            createStudentToolStripMenuItem.Click += createStudentToolStripMenuItem_Click;
            // 
            // linkModulesToolStripMenuItem
            // 
            linkModulesToolStripMenuItem.Name = "linkModulesToolStripMenuItem";
            linkModulesToolStripMenuItem.Size = new Size(308, 44);
            linkModulesToolStripMenuItem.Text = "Link Modules";
            linkModulesToolStripMenuItem.Click += linkModulesToolStripMenuItem_Click;
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(308, 44);
            searchStudentToolStripMenuItem.Text = "Search Student";
            searchStudentToolStripMenuItem.Click += searchStudentToolStripMenuItem_Click;
            // 
            // modulesToolStripMenuItem
            // 
            modulesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createModuleToolStripMenuItem, viewModulesToolStripMenuItem, searchModulesToolStripMenuItem });
            modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            modulesToolStripMenuItem.Size = new Size(127, 38);
            modulesToolStripMenuItem.Text = "Modules";
            // 
            // createModuleToolStripMenuItem
            // 
            createModuleToolStripMenuItem.Name = "createModuleToolStripMenuItem";
            createModuleToolStripMenuItem.Size = new Size(359, 44);
            createModuleToolStripMenuItem.Text = "Create Module";
            createModuleToolStripMenuItem.Click += createModuleToolStripMenuItem_Click;
            // 
            // viewModulesToolStripMenuItem
            // 
            viewModulesToolStripMenuItem.Name = "viewModulesToolStripMenuItem";
            viewModulesToolStripMenuItem.Size = new Size(359, 44);
            viewModulesToolStripMenuItem.Text = "View Modules";
            viewModulesToolStripMenuItem.Click += viewModulesToolStripMenuItem_Click;
            // 
            // searchModulesToolStripMenuItem
            // 
            searchModulesToolStripMenuItem.Name = "searchModulesToolStripMenuItem";
            searchModulesToolStripMenuItem.Size = new Size(359, 44);
            searchModulesToolStripMenuItem.Text = "Search Modules";
            searchModulesToolStripMenuItem.Click += searchModulesToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(268, 74);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(335, 53);
            label1.TabIndex = 2;
            label1.Text = "Create Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 191);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 246);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 4;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 316);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 5;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 439);
            label5.Name = "label5";
            label5.Size = new Size(177, 32);
            label5.TabIndex = 6;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 501);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 7;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 379);
            label7.Name = "label7";
            label7.Size = new Size(154, 32);
            label7.TabIndex = 8;
            label7.Text = "Date Of Birth";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(392, 191);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(380, 39);
            txt_name.TabIndex = 9;
            // 
            // txt_surname
            // 
            txt_surname.Location = new Point(392, 246);
            txt_surname.Name = "txt_surname";
            txt_surname.Size = new Size(380, 39);
            txt_surname.TabIndex = 10;
            // 
            // txt_gender
            // 
            txt_gender.Location = new Point(392, 316);
            txt_gender.Name = "txt_gender";
            txt_gender.Size = new Size(380, 39);
            txt_gender.TabIndex = 11;
            // 
            // dt_dob
            // 
            dt_dob.Location = new Point(392, 379);
            dt_dob.Name = "dt_dob";
            dt_dob.Size = new Size(380, 39);
            dt_dob.TabIndex = 12;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(392, 439);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(380, 39);
            txt_phone.TabIndex = 13;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(392, 501);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(380, 39);
            txt_address.TabIndex = 14;
            // 
            // Create
            // 
            Create.Location = new Point(303, 605);
            Create.Name = "Create";
            Create.Size = new Size(264, 72);
            Create.TabIndex = 15;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = true;
            Create.Click += Create_Click;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(94, 690);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 32);
            lbl_error.TabIndex = 16;
            // 
            // CreateStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 759);
            Controls.Add(lbl_error);
            Controls.Add(Create);
            Controls.Add(txt_address);
            Controls.Add(txt_phone);
            Controls.Add(dt_dob);
            Controls.Add(txt_gender);
            Controls.Add(txt_surname);
            Controls.Add(txt_name);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "CreateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateStudent";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem createStudentToolStripMenuItem;
        private ToolStripMenuItem modulesToolStripMenuItem;
        private ToolStripMenuItem createModuleToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem linkModulesToolStripMenuItem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_name;
        private TextBox txt_surname;
        private TextBox txt_gender;
        private DateTimePicker dt_dob;
        private TextBox txt_phone;
        private TextBox txt_address;
        private Button Create;
        private Label lbl_error;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem viewModulesToolStripMenuItem;
        private ToolStripMenuItem searchModulesToolStripMenuItem;
    }
}