namespace PRG271_Project_Presentation
{
    partial class LinkModules
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
            cmb_students = new ComboBox();
            dg_Selected = new DataGridView();
            label1 = new Label();
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
            dg_unselected = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_Selected).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_unselected).BeginInit();
            SuspendLayout();
            // 
            // cmb_students
            // 
            cmb_students.FormattingEnabled = true;
            cmb_students.Location = new Point(220, 68);
            cmb_students.Name = "cmb_students";
            cmb_students.Size = new Size(541, 40);
            cmb_students.TabIndex = 0;
            cmb_students.SelectedIndexChanged += cmb_students_SelectedIndexChanged;
            // 
            // dg_Selected
            // 
            dg_Selected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Selected.Location = new Point(12, 135);
            dg_Selected.Name = "dg_Selected";
            dg_Selected.RowHeadersWidth = 82;
            dg_Selected.RowTemplate.Height = 41;
            dg_Selected.Size = new Size(963, 709);
            dg_Selected.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 71);
            label1.Name = "label1";
            label1.Size = new Size(168, 32);
            label1.TabIndex = 2;
            label1.Text = "Student Name";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, modulesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2069, 40);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStudentsToolStripMenuItem, createStudentToolStripMenuItem, linkModulesToolStripMenuItem, searchStudentToolStripMenuItem });
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(127, 36);
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
            modulesToolStripMenuItem.Size = new Size(127, 36);
            modulesToolStripMenuItem.Text = "Modules";
            // 
            // createModuleToolStripMenuItem
            // 
            createModuleToolStripMenuItem.Name = "createModuleToolStripMenuItem";
            createModuleToolStripMenuItem.Size = new Size(308, 44);
            createModuleToolStripMenuItem.Text = "Create Module";
            createModuleToolStripMenuItem.Click += createModuleToolStripMenuItem_Click;
            // 
            // viewModulesToolStripMenuItem
            // 
            viewModulesToolStripMenuItem.Name = "viewModulesToolStripMenuItem";
            viewModulesToolStripMenuItem.Size = new Size(308, 44);
            viewModulesToolStripMenuItem.Text = "View Modules";
            viewModulesToolStripMenuItem.Click += viewModulesToolStripMenuItem_Click;
            // 
            // searchModuleToolStripMenuItem
            // 
            searchModuleToolStripMenuItem.Name = "searchModuleToolStripMenuItem";
            searchModuleToolStripMenuItem.Size = new Size(308, 44);
            searchModuleToolStripMenuItem.Text = "Search Module";
            searchModuleToolStripMenuItem.Click += searchModuleToolStripMenuItem_Click;
            // 
            // dg_unselected
            // 
            dg_unselected.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_unselected.Location = new Point(1086, 135);
            dg_unselected.Name = "dg_unselected";
            dg_unselected.RowHeadersWidth = 82;
            dg_unselected.RowTemplate.Height = 41;
            dg_unselected.Size = new Size(997, 709);
            dg_unselected.TabIndex = 4;
            // 
            // LinkModules
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2069, 856);
            Controls.Add(dg_unselected);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Controls.Add(dg_Selected);
            Controls.Add(cmb_students);
            Name = "LinkModules";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LinkModules";
            ((System.ComponentModel.ISupportInitialize)dg_Selected).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_unselected).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_students;
        private DataGridView dg_Selected;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem createStudentToolStripMenuItem;
        private ToolStripMenuItem linkModulesToolStripMenuItem;
        private ToolStripMenuItem searchStudentToolStripMenuItem;
        private ToolStripMenuItem modulesToolStripMenuItem;
        private ToolStripMenuItem createModuleToolStripMenuItem;
        private ToolStripMenuItem viewModulesToolStripMenuItem;
        private ToolStripMenuItem searchModuleToolStripMenuItem;
        private DataGridView dg_unselected;
    }
}