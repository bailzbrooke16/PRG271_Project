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

        public List<string> GetStudents()
        {
            return new List<string>();
        }
    }
}
