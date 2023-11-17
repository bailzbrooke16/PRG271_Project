using PRG271_Project_DataLayer;
using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_Services
{
    
    public  class StudentService
    {
        private DataManager _dataManager;
        public StudentService() { 
            this._dataManager = new DataManager();
        }
        public List<Student> GetStudents()
        {
            return this._dataManager.GetStudents();
        }

        //public Student CreateStudent(Student student)
        //{
        //    return this._studentManager.CreateStudent(student);
        //}

        public void DeleteStudent(int? id)
        {
            this._dataManager.DeleteStudent(id);
        }

        public Student UpdateStudent(int? id, Student student)
        {
            return this._dataManager.UpdateStudent(id, student);
        }
    }
}
