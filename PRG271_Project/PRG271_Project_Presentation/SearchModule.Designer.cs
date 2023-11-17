namespace PRG271_Project_Presentation
{
    partial class SearchModule
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
            lbl_error = new Label();
            lbl_result_URLLink = new Label();
            lbl_result_description = new Label();
            lbl_result_name = new Label();
            btn_search = new Button();
            txt_search = new TextBox();
            label8 = new Label();
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(65, 424);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 32);
            lbl_error.TabIndex = 56;
            // 
            // lbl_result_URLLink
            // 
            lbl_result_URLLink.AutoSize = true;
            lbl_result_URLLink.Location = new Point(327, 353);
            lbl_result_URLLink.Name = "lbl_result_URLLink";
            lbl_result_URLLink.Size = new Size(0, 32);
            lbl_result_URLLink.TabIndex = 52;
            // 
            // lbl_result_description
            // 
            lbl_result_description.AutoSize = true;
            lbl_result_description.Location = new Point(327, 283);
            lbl_result_description.Name = "lbl_result_description";
            lbl_result_description.Size = new Size(0, 32);
            lbl_result_description.TabIndex = 51;
            // 
            // lbl_result_name
            // 
            lbl_result_name.AutoSize = true;
            lbl_result_name.Location = new Point(327, 237);
            lbl_result_name.Name = "lbl_result_name";
            lbl_result_name.Size = new Size(0, 32);
            lbl_result_name.TabIndex = 50;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(527, 136);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(78, 44);
            btn_search.TabIndex = 49;
            btn_search.Text = "Go";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(297, 141);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(188, 39);
            txt_search.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 148);
            label8.Name = "label8";
            label8.Size = new Size(160, 32);
            label8.TabIndex = 47;
            label8.Text = "Module Code";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, modulesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 42);
            menuStrip1.TabIndex = 46;
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
            viewStudentsToolStripMenuItem.Size = new Size(359, 44);
            viewStudentsToolStripMenuItem.Text = "View Students";
            viewStudentsToolStripMenuItem.Click += viewStudentsToolStripMenuItem_Click;
            // 
            // createStudentToolStripMenuItem
            // 
            createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            createStudentToolStripMenuItem.Size = new Size(359, 44);
            createStudentToolStripMenuItem.Text = "Create Student";
            createStudentToolStripMenuItem.Click += createStudentToolStripMenuItem_Click;
            // 
            // linkModulesToolStripMenuItem
            // 
            linkModulesToolStripMenuItem.Name = "linkModulesToolStripMenuItem";
            linkModulesToolStripMenuItem.Size = new Size(359, 44);
            linkModulesToolStripMenuItem.Text = "Link Modules";
            linkModulesToolStripMenuItem.Click += linkModulesToolStripMenuItem_Click;
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(359, 44);
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
            createModuleToolStripMenuItem.Size = new Size(318, 44);
            createModuleToolStripMenuItem.Text = "Create Module";
            createModuleToolStripMenuItem.Click += createModuleToolStripMenuItem_Click;
            // 
            // viewModulesToolStripMenuItem
            // 
            viewModulesToolStripMenuItem.Name = "viewModulesToolStripMenuItem";
            viewModulesToolStripMenuItem.Size = new Size(318, 44);
            viewModulesToolStripMenuItem.Text = "View Modules";
            viewModulesToolStripMenuItem.Click += viewModulesToolStripMenuItem_Click;
            // 
            // searchModulesToolStripMenuItem
            // 
            searchModulesToolStripMenuItem.Name = "searchModulesToolStripMenuItem";
            searchModulesToolStripMenuItem.Size = new Size(318, 44);
            searchModulesToolStripMenuItem.Text = "Search Modules";
            searchModulesToolStripMenuItem.Click += searchModulesToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 353);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 42;
            label4.Text = "URL Link";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 283);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 41;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 228);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 40;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(198, 63);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(334, 53);
            label1.TabIndex = 39;
            label1.Text = "Search Module";
            // 
            // SearchModule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(lbl_error);
            Controls.Add(lbl_result_URLLink);
            Controls.Add(lbl_result_description);
            Controls.Add(lbl_result_name);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(label8);
            Controls.Add(menuStrip1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchModule";
            Text = "SearchModule";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_error;
        private Label lbl_result_URLLink;
        private Label lbl_result_description;
        private Label lbl_result_name;
        private Button btn_search;
        private TextBox txt_search;
        private Label label8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem createStudentToolStripMenuItem;
        private ToolStripMenuItem linkModulesToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem modulesToolStripMenuItem;
        private ToolStripMenuItem createModuleToolStripMenuItem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem viewModulesToolStripMenuItem;
        private ToolStripMenuItem searchModulesToolStripMenuItem;
    }
}