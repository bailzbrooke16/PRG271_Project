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
    public partial class CreateModule : Form
    {
        private ModuleService _moduleService;
        public CreateModule()
        {
            this._moduleService = new ModuleService();
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
            this.Dispose();
            cs.Show();
        }

        private void createModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateModule cm = new CreateModule();
            cm.Show();
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
            this.Dispose();
            ss.Show();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

            string name = this.txt_name.Text;
            string description = this.txt_description.Text;
            string url = this.txt_url.Text;

            if(name != "")
            {
                if(description != "")
                {
                    if(url != "")
                    {
                        Module newModule = new Module()
                        {
                            Name = name,
                            Description = description,
                            URLLink = url
                        };
                        this._moduleService.CreateModule(newModule);
                        MainForm mf = new MainForm();
                        this.Dispose();
                        mf.Show();
                    }
                }
            }

           
        }
    }
}
