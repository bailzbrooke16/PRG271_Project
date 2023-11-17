using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_DataLayer
{
    public class DataManager
    {
        private string _connectionString;
        StudentManager _studentManager;
        ModuleManager _moduleManager;
        private const string filePath = @"C:\Users\Bailey\Documents\GitHub\PRG271_Project\PRG271_Project\users.txt";
        public DataManager()
        {
            this._connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=PRG271_Project;"
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

        public Student UpdateStudent(int? id, Student student)
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

        #region System Methods
        public string GetLoginHash(string username)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        string[] fields = line.Split(',');
                        if (fields[0] == username)
                        {
                            return fields[1];
                        }
                    }
                }
                return "error";
            }
            catch(Exception ex) {
                return "error";
            }
            
        }

        public Boolean Register(string username, string hashedPassword)
        {
            try
            {
                try
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            string[] fields = line.Split(',');
                            if (fields[0] == username)
                            {
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
                
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLineAsync(username + "," + hashedPassword);
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }

        #endregion
    }
}
