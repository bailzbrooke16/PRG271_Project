using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_DataLayer
{
    public class DataManager
    {
        private string _connectionString;
        StudentManager _studentManager;
        ModuleManager _moduleManager;
        public DataManager()
        {
            this._connectionString = "Data Source=(local);Initial Catalog=PRG271_Project;"
            + "Integrated Security=true";
            this._studentManager = new StudentManager(this._connectionString);
            this._moduleManager = new ModuleManager(this._connectionString);
        }

        #region Student Entry Methods

        public List<Student> GetStudents()
        {
            return this._studentManager.GetStudents();
        }

        public Student GetStudent()
        {
            return this._studentManager.GetStudent(1);
        }

        public Student CreateStudent(Student student)
        {
            return this._studentManager.CreateStudent(student);
        }

        public void DeleteStudent(int id)
        {
           this._studentManager.DeleteStudent(id);
        }

        public Student UpdateStudent(int id, Student student)
        {
            return this._studentManager.UpdateStudent(id, student);
        }
        #endregion

        #region Module Entry Methods
        public List<Module> GetModules()
        {
            return this._moduleManager.GetModules();
        }

        public Module GetModule()
        {
            return this._moduleManager.GetModule(1);
        }

        public Module CreateModule(Module module)
        {
            return this._moduleManager.CreateModule(module);
        }

        public void DeleteModule(int id)
        {
            this._moduleManager.DeleteModule(id);
        }

        public Module UpdateModule(int id, Module module)
        {
            return this._moduleManager.UpdateModule(id, module);
        }

        #endregion
    }
}
