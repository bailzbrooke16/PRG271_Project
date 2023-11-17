namespace PRG271_Project_Presentation
{
    partial class SearchStudent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsToolStripMenuItem = new ToolStripMenuItem();
            createStudentToolStripMenuItem = new ToolStripMenuItem();
            linkModulesToolStripMenuItem = new ToolStripMenuItem();
            searchStudentToolStripMenuItem = new ToolStripMenuItem();
            modulesToolStripMenuItem = new ToolStripMenuItem();
            createModuleToolStripMenuItem = new ToolStripMenuItem();
            viewModulesToolStripMenuItem = new ToolStripMenuItem();
            searchModuleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            label8 = new Label();
            txt_search = new TextBox();
            btn_search = new Button();
            lbl_result_name = new Label();
            lbl_result_surname = new Label();
            lbl_result_gender = new Label();
            lbl_result_dob = new Label();
            lbl_result_phone = new Label();
            lbl_result_address = new Label();
            lbl_error = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(204, 82);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(343, 53);
            label1.TabIndex = 15;
            label1.Text = "Search Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 247);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 16;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 302);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 17;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 372);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 18;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 495);
            label5.Name = "label5";
            label5.Size = new Size(177, 32);
            label5.TabIndex = 19;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 557);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 20;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 435);
            label7.Name = "label7";
            label7.Size = new Size(154, 32);
            label7.TabIndex = 21;
            label7.Text = "Date Of Birth";
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
            modulesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createModuleToolStripMenuItem, viewModulesToolStripMenuItem, searchModuleToolStripMenuItem });
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
            // searchModuleToolStripMenuItem
            // 
            searchModuleToolStripMenuItem.Name = "searchModuleToolStripMenuItem";
            searchModuleToolStripMenuItem.Size = new Size(359, 44);
            searchModuleToolStripMenuItem.Text = "Search Module";
            searchModuleToolStripMenuItem.Click += searchModuleToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, modulesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(795, 42);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 167);
            label8.Name = "label8";
            label8.Size = new Size(192, 32);
            label8.TabIndex = 29;
            label8.Text = "Student Number";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(303, 160);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(188, 39);
            txt_search.TabIndex = 30;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(533, 155);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(78, 44);
            btn_search.TabIndex = 31;
            btn_search.Text = "Go";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // lbl_result_name
            // 
            lbl_result_name.AutoSize = true;
            lbl_result_name.Location = new Point(333, 256);
            lbl_result_name.Name = "lbl_result_name";
            lbl_result_name.Size = new Size(0, 32);
            lbl_result_name.TabIndex = 32;
            // 
            // lbl_result_surname
            // 
            lbl_result_surname.AutoSize = true;
            lbl_result_surname.Location = new Point(333, 302);
            lbl_result_surname.Name = "lbl_result_surname";
            lbl_result_surname.Size = new Size(0, 32);
            lbl_result_surname.TabIndex = 33;
            // 
            // lbl_result_gender
            // 
            lbl_result_gender.AutoSize = true;
            lbl_result_gender.Location = new Point(333, 372);
            lbl_result_gender.Name = "lbl_result_gender";
            lbl_result_gender.Size = new Size(0, 32);
            lbl_result_gender.TabIndex = 34;
            // 
            // lbl_result_dob
            // 
            lbl_result_dob.AutoSize = true;
            lbl_result_dob.Location = new Point(333, 446);
            lbl_result_dob.Name = "lbl_result_dob";
            lbl_result_dob.Size = new Size(0, 32);
            lbl_result_dob.TabIndex = 35;
            // 
            // lbl_result_phone
            // 
            lbl_result_phone.AutoSize = true;
            lbl_result_phone.Location = new Point(333, 495);
            lbl_result_phone.Name = "lbl_result_phone";
            lbl_result_phone.Size = new Size(0, 32);
            lbl_result_phone.TabIndex = 36;
            // 
            // lbl_result_address
            // 
            lbl_result_address.AutoSize = true;
            lbl_result_address.Location = new Point(333, 557);
            lbl_result_address.Name = "lbl_result_address";
            lbl_result_address.Size = new Size(0, 32);
            lbl_result_address.TabIndex = 37;
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(65, 635);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 32);
            lbl_error.TabIndex = 38;
            // 
            // SearchStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 726);
            Controls.Add(lbl_error);
            Controls.Add(lbl_result_address);
            Controls.Add(lbl_result_phone);
            Controls.Add(lbl_result_dob);
            Controls.Add(lbl_result_gender);
            Controls.Add(lbl_result_surname);
            Controls.Add(lbl_result_name);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(label8);
            Controls.Add(menuStrip1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchStudent";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem createStudentToolStripMenuItem;
        private ToolStripMenuItem linkModulesToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem modulesToolStripMenuItem;
        private ToolStripMenuItem createModuleToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label label8;
        private TextBox txt_search;
        private Button btn_search;
        private Label lbl_result_name;
        private Label lbl_result_surname;
        private Label lbl_result_gender;
        private Label lbl_result_dob;
        private Label lbl_result_phone;
        private Label lbl_result_address;
        private Label lbl_error;
        private ToolStripMenuItem viewModulesToolStripMenuItem;
        private ToolStripMenuItem searchModuleToolStripMenuItem;
    }
}