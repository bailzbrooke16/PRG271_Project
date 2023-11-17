using PRG271_Project_DataLayer;
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
    public partial class CreateStudent : Form
    {
        private StudentService _studentService;
        public CreateStudent()
        {
            this._studentService = new StudentService();
            InitializeComponent();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Dispose();
            mf.Show();
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

        private void Create_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text;
            string surname = this.txt_surname.Text;
            string gender = this.txt_gender.Text;
            string phone = this.txt_phone.Text;
            string address = this.txt_address.Text;
            DateTime DOB = this.dt_dob.Value;

            if (name != "" && surname != "" && gender != "" && phone != "" && address != "")
            {
                Student newStudent = new Student()
                {
                    Name = name,
                    Surname = surname,
                    Gender = gender,
                    Phone = phone,
                    Address = address,
                    DateOfBirth = DOB,
                    Image = null
                };

                this._studentService.CreateStudent(newStudent);
                MainForm mf = new MainForm();
                this.Dispose();
                mf.Show();
            }
            else
            {
                lbl_error.Text = "There is missing field information";
            }


        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            this.Dispose();
            ss.Show();
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

        private void searchModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchModule sm = new SearchModule();  
            sm.Show();
            this.Dispose();
        }
    }
}
