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
            List<Module> modules = new List<Module>();

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Modules"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Module module = new Module
                            {
                                Code = (int)reader["Code"],
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                URLLink = reader["URLLink"].ToString(),

                            };

                            modules.Add(module);
                        }
                    }
                }
            }

            return modules;
        }

        public Module GetModule(int id)
        {

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Modules Where Code = @Code";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Code", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Module module = new Module
                            {
                                Code = (int)reader["Code"],
                                Name = reader["Name"].ToString(),
                                Description = reader["Description"].ToString(),
                                URLLink = reader["URLLink"].ToString(),

                            };

                            return module;
                        }
                    }
                }
            }

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

                    // Return the created module
                    return module;
                }
            }
        }

        public void DeleteModule(int id)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string deleteQuery = "delete from StudentModules " +
                                     "WHERE ModuleId = @ModuleID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ModuleID", id);

                    int rowsAffected = command.ExecuteNonQuery();


                }



                deleteQuery = "delete from  Modules " +
                                     "WHERE Code = @Code";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Code", id);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

        public Module UpdateModule(int id, Module module)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Modules " +
                                     "SET Name = @Name, " +
                                     "    Description = @Description, " +
                                     "    URLLink = @URLLink " +
                                     "WHERE Code = @Code";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Name", module.Name);
                    command.Parameters.AddWithValue("@Description", module.Description);
                    command.Parameters.AddWithValue("@URLLink", module.URLLink);

                    command.Parameters.AddWithValue("@Code", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return module;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }
}
