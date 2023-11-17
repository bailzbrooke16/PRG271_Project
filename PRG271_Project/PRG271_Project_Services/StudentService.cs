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
            List<Student> studentList = new List<Student>
        {
            new Student
            {
                Number = 1,
                Name = "John",
                Surname = "Doe",
                Image = null,
                DateOfBirth = new DateTime(1990, 5, 15),
                Gender = "Male",
                Phone = "123-456-7890",
                Address = "123 Main St"
            },
            new Student
            {
                Number = 2,
                Name = "Jane",
                Surname = "Smith",
                Image = null,
                DateOfBirth = new DateTime(1995, 8, 20),
                Gender = "Female",
                Phone = "987-654-3210",
                Address = "456 Oak St"
            },
            // Add more students as needed
        };

            return studentList;
        }

        //public Student CreateStudent(Student student)
        //{
        //    return this._studentManager.CreateStudent(student);
        //}

        //public void DeleteStudent(int id)
        //{
        //    this._studentManager.DeleteStudent(id);
        //}

        public Student UpdateStudent(int? id, Student student)
        {
            return this._dataManager.UpdateStudent(id, student);
        }
    }
}
