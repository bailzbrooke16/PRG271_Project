namespace PRG271_Project_Presentation
{
    partial class CreateModule
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
            searchModuleToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            txt_name = new TextBox();
            txt_description = new TextBox();
            label3 = new Label();
            txt_url = new TextBox();
            label4 = new Label();
            btn_create = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, modulesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(810, 42);
            menuStrip1.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(227, 99);
            label1.Name = "label1";
            label1.Size = new Size(327, 62);
            label1.TabIndex = 3;
            label1.Text = "Create Module";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 196);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 4;
            label2.Text = "Module Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(341, 199);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(294, 39);
            txt_name.TabIndex = 5;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(341, 278);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(294, 39);
            txt_description.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 278);
            label3.Name = "label3";
            label3.Size = new Size(225, 32);
            label3.TabIndex = 7;
            label3.Text = "Module Description";
            // 
            // txt_url
            // 
            txt_url.Location = new Point(344, 353);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(293, 39);
            txt_url.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(97, 353);
            label4.Name = "label4";
            label4.Size = new Size(134, 32);
            label4.TabIndex = 9;
            label4.Text = "Module Url";
            // 
            // btn_create
            // 
            btn_create.Location = new Point(233, 456);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(295, 81);
            btn_create.TabIndex = 10;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // CreateModule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 765);
            Controls.Add(btn_create);
            Controls.Add(label4);
            Controls.Add(txt_url);
            Controls.Add(label3);
            Controls.Add(txt_description);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "CreateModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Module";
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
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private Label label2;
        private TextBox txt_name;
        private TextBox txt_description;
        private Label label3;
        private TextBox txt_url;
        private Label label4;
        private Button btn_create;
        private ToolStripMenuItem viewModulesToolStripMenuItem;
        private ToolStripMenuItem searchModuleToolStripMenuItem;
    }
}