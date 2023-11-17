using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_DataLayer
{
    public class ModuleManager
    {
        private string _connectionString;
        public ModuleManager(string connectionString) {
            this._connectionString = connectionString;
        }

        public List<Module> GetModules()
        {
            return new List<Module>();
        }

        public Module GetModule(int id)
        {
            return null;
        }

        public Module CreateModule(Module module)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Modules ( Name, Description, URLLink) " +
                                     "VALUES (@Name, @Description, @URLLink);" +
                                     "SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Name", module.Name);
                    command.Parameters.AddWithValue("@Description", module.Description);
                    command.Parameters.AddWithValue("@URLLink", module.URLLink);

                    int newCode = Convert.ToInt32(command.ExecuteScalar());

                    module.Code = newCode;

                    // Return the created student
                    return module;
                }
            }
        }

        public void DeleteModule(int id)
        {

        }

        public Module UpdateModule(int id, Module module)
        {
            return null;
        }
    }
}
