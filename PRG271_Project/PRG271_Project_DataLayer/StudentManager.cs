using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_DataLayer
{
    public class StudentManager
    {
        private string _connectionString;
        public StudentManager(string connectionString) {
            this._connectionString = connectionString;
        }

        public List<Student> GetStudents()
        {
            return new List<Student>();
        }

        public Student GetStudent(int id)
        {
            return null;
        }

        public Student CreateStudent(Student student)
        {
            return null;
        }

        public void DeleteStudent(int id)
        {

        }

        public Student UpdateStudent(int? id, Student student)
        {
            return null;
        }
    }
}
