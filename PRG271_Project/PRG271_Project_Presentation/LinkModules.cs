using PRG271_Project_DataLayer.Models;
using PRG271_Project_Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG271_Project_Presentation
{
    public partial class LinkModules : Form
    {
        private StudentService _studentService;
        private LinkingService _linkingService;
        public LinkModules()
        {
            this._studentService = new StudentService();
            this._linkingService = new LinkingService();
            InitializeComponent();
            List<Student> students = this._studentService.GetStudents();
            this.cmb_students.DataSource = students;
            this.cmb_students.DisplayMember = "Name";

            this.dg_Selected.DataSource = this._linkingService.GetActiveModules(students[0].Number);
            this.dg_unselected.DataSource = this._linkingService.GetUnActiveModules(students[0].Number);


        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Dispose();
        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStudent cs = new CreateStudent();
            cs.Show();
            this.Dispose();
        }

        private void linkModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkModules lm = new LinkModules();
            this.Dispose();
            lm.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
            this.Dispose();
        }

        private void createModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateModule cm = new CreateModule();
            cm.Show();
            this.Dispose();
        }

        private void viewModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainModules mm = new MainModules();
            mm.Show();
            this.Dispose();
        }

        private void searchModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchModule sm = new SearchModule();
            sm.Show();
            this.Dispose();
        }

        private void cmb_students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
