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
    public partial class MainModules : Form
    {
        private ModuleService _moduleService;
        public MainModules()
        {
            this._moduleService = new ModuleService();
            InitializeComponent();
            this.dt_modules.DataSource = this._moduleService.GetModules();

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            this.dt_modules.Columns.Add(deleteButtonColumn);
        }

        private void viewModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainModules mm = new MainModules();
            mm.Show();
            this.Dispose();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Dispose();
        }

        private void createModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateModule cm = new CreateModule();
            cm.Show();
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

        private void dt_modules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dataGridView = (DataGridView)sender;

            //Get where the change occured
            if(e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;

                //Get the student that the change occured to
                Module modifiedModule = this._moduleService.GetModules()[rowIndex];

                if (dataGridView.CurrentCell.EditedFormattedValue == "Delete")
                {
                    this._moduleService.DeleteModule(modifiedModule.Code);
                    this.dt_modules.DataSource = this._moduleService.GetModules();
                }
            }
            
        }

        private void dt_modules_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //Get where the change occured
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            //Get the student that the change occured to
            Module modifiedModule = this._moduleService.GetModules()[rowIndex];
            //get the attribute and value that changed
            string attributeName = dataGridView.Columns[columnIndex].Name;
            object modifiedValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;

            //adjust the value for that student
            var property = modifiedModule.GetType().GetProperty(attributeName);
            if (property != null && property.CanWrite)
            {
                property.SetValue(modifiedModule, modifiedValue);
            }

            //Send that object off to be updated in the DB
            this._moduleService.UpdateModule(modifiedModule.Code, modifiedModule);
        }

        private void searchModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchModule sm = new SearchModule();
            sm.Show();
            this.Dispose();
        }
    }
}
