namespace PRG271_Project_Presentation
{
    partial class MainModules
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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, modulesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1479, 42);
            menuStrip1.TabIndex = 3;
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
            // 
            // createStudentToolStripMenuItem
            // 
            createStudentToolStripMenuItem.Name = "createStudentToolStripMenuItem";
            createStudentToolStripMenuItem.Size = new Size(308, 44);
            createStudentToolStripMenuItem.Text = "Create Student";
            // 
            // linkModulesToolStripMenuItem
            // 
            linkModulesToolStripMenuItem.Name = "linkModulesToolStripMenuItem";
            linkModulesToolStripMenuItem.Size = new Size(308, 44);
            linkModulesToolStripMenuItem.Text = "Link Modules";
            // 
            // searchStudentToolStripMenuItem
            // 
            searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            searchStudentToolStripMenuItem.Size = new Size(308, 44);
            searchStudentToolStripMenuItem.Text = "Search Student";
            // 
            // modulesToolStripMenuItem
            // 
            modulesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createModuleToolStripMenuItem, viewModulesToolStripMenuItem });
            modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            modulesToolStripMenuItem.Size = new Size(127, 38);
            modulesToolStripMenuItem.Text = "Modules";
            // 
            // createModuleToolStripMenuItem
            // 
            createModuleToolStripMenuItem.Name = "createModuleToolStripMenuItem";
            createModuleToolStripMenuItem.Size = new Size(359, 44);
            createModuleToolStripMenuItem.Text = "Create Module";
            // 
            // viewModulesToolStripMenuItem
            // 
            viewModulesToolStripMenuItem.Name = "viewModulesToolStripMenuItem";
            viewModulesToolStripMenuItem.Size = new Size(359, 44);
            viewModulesToolStripMenuItem.Text = "View Modules";
            viewModulesToolStripMenuItem.Click += viewModulesToolStripMenuItem_Click;
            // 
            // MainModules
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 722);
            Controls.Add(menuStrip1);
            Name = "MainModules";
            Text = "MainModules";
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
        private ToolStripMenuItem linkModulesToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem modulesToolStripMenuItem;
        private ToolStripMenuItem createModuleToolStripMenuItem;
        private ToolStripMenuItem viewModulesToolStripMenuItem;
    }
}