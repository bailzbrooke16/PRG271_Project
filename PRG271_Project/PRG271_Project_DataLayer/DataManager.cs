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
        public DataManager()
        {
            this._connectionString = "Data Source=(local);Initial Catalog=PRG271_Project;"
            + "Integrated Security=true";
            this._studentManager = new StudentManager(this._connectionString);
        }


        public List<string> GetStudents()
        {
            return this._studentManager.GetStudents();
        } 
    }
}
