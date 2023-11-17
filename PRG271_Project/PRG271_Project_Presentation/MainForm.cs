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
    public partial class MainForm : Form
    {
        private StudentService _studentService;
        public MainForm()
        {
            this._studentService = new StudentService();
            InitializeComponent();
            this.dg_students.DataSource = this._studentService.GetStudents();
            this.dg_students.Columns[0].ReadOnly = true;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            this.dg_students.Columns.Add(deleteButtonColumn);
        }

        private void dg_students_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //Get where the change occured
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            //Get the student that the change occured to
            Student modifiedStudent = this._studentService.GetStudents()[rowIndex];
            //get the attribute and value that changed
            string attributeName = dataGridView.Columns[columnIndex].Name;
            object modifiedValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;

            //adjust the value for that student
            var property = modifiedStudent.GetType().GetProperty(attributeName);
            if (property != null && property.CanWrite)
            {
                property.SetValue(modifiedStudent, modifiedValue);
            }

            //Send that object off to be updated in the DB
            this._studentService.UpdateStudent(modifiedStudent.Number, modifiedStudent);

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
            this.Dispose();
            cs.Show();
        }

        private void createModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateModule cm = new CreateModule();
            this.Dispose();
            cm.Show();
        }

        private void linkModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkModules lm = new LinkModules();
            this.Dispose();
            lm.Show();
        }

        private void dg_students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //Get where the change occured
            int rowIndex = e.RowIndex;


            //Get the student that the change occured to
            Student modifiedStudent = this._studentService.GetStudents()[rowIndex];
            this._studentService.DeleteStudent(modifiedStudent.Number);
            this.dg_students.DataSource = this._studentService.GetStudents();
        }
    }
}
