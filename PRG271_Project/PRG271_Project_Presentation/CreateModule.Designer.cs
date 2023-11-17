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
            modulesToolStripMenuItem = new ToolStripMenuItem();
            createModuleToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
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
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStudentsToolStripMenuItem, createStudentToolStripMenuItem, linkModulesToolStripMenuItem });
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
            // modulesToolStripMenuItem
            // 
            modulesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createModuleToolStripMenuItem });
            modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            modulesToolStripMenuItem.Size = new Size(127, 38);
            modulesToolStripMenuItem.Text = "Modules";
            // 
            // createModuleToolStripMenuItem
            // 
            createModuleToolStripMenuItem.Name = "createModuleToolStripMenuItem";
            createModuleToolStripMenuItem.Size = new Size(306, 44);
            createModuleToolStripMenuItem.Text = "Create Module";
            createModuleToolStripMenuItem.Click += createModuleToolStripMenuItem_Click;
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
            // CreateModule
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 678);
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
    }
}