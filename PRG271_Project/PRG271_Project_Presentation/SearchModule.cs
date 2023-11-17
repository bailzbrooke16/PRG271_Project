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
using System.Windows.Forms.VisualStyles;

namespace PRG271_Project_Presentation
{
    public partial class SearchModule : Form
    {
        private ModuleService _moduleService;

        public SearchModule()
        {
            this._moduleService = new ModuleService();
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            lbl_result_name.Text = "";
            lbl_result_description.Text = "";
            lbl_result_URLLink.Text = "";
            lbl_error.Text = "";

            string strcode = this.txt_search.Text;
            int code = Convert.ToInt32(strcode);

            Module result = this._moduleService.GetModule(code);

            if (result != null)
            {
                lbl_result_name.Text = result.Name;
                lbl_result_description.Text = result.Description;
                lbl_result_URLLink.Text = result.URLLink;
            }
            else
            {
                lbl_error.Text = "No results were produced";
            }

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
            this.Dispose();
            sm.Show();
        }

        private void createModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateModule cm = new CreateModule();
            cm.Show();
            this.Dispose();
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
            lm.Show();
            this.Dispose();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
            this.Dispose();
        }
    }
}
