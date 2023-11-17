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
    public partial class SearchStudent : Form
    {
        private StudentService _studentService;
        public SearchStudent()
        {
            this._studentService = new StudentService();
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lbl_result_name.Text = "";
            lbl_result_surname.Text = "";
            lbl_result_gender.Text = "";
            lbl_result_phone.Text = "";
            lbl_result_dob.Text = "";
            lbl_result_address.Text = "";
            lbl_error.Text = "";

            string code = this.txt_search.Text;
            int Number = Convert.ToInt32(code);

            Student result = this._studentService.GetStudent(Number);
            if (result != null)
            {
                lbl_result_name.Text = result.Name;
                lbl_result_surname.Text = result.Surname;
                lbl_result_gender.Text = result.Gender;
                lbl_result_phone.Text = result.Phone;
                lbl_result_dob.Text = result.DateOfBirth.ToString();
                lbl_result_address.Text = result.Address;
            }
            else
            {
                lbl_error.Text = "No results produced";
            }

        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
            this.Dispose();
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
            this.Dispose();
            cs.Show();
        }

        private void linkModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkModules lm = new LinkModules();
            this.Dispose();
            lm.Show();
        }
    }
}
