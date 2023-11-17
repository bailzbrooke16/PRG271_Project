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
        }

        private void dg_students_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            //Get where the change occured
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            
            //get the attribute and value that changed
            string attributeName = dataGridView.Columns[columnIndex].Name;
            object modifiedValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;
          
            //Get the student that the change occured to
            Student modifiedStudent = this._studentService.GetStudents()[rowIndex];
            
            //adjust the value for that student
            var property = modifiedStudent.GetType().GetProperty(attributeName);
            if (property != null && property.CanWrite)
            {
                property.SetValue(modifiedStudent, modifiedValue);
            }

            //Send that object off to be updated in the DB
            this._studentService.UpdateStudent(modifiedStudent.Number, modifiedStudent);

        }
    }
}
