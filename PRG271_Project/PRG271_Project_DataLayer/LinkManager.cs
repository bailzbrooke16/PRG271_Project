using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG271_Project_DataLayer
{
    public class LinkManager
    {
        private string _connectionString;
        public LinkManager(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public List<Link> GetLinks()
        {
            List<Link> links = new List<Link>();

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM StudentModules";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Link link = new Link
                            {
                                StudentID = (int)reader["StudentID"],
                                ModuleID = (int)reader["ModuleID"],

                            };

                            links.Add(link);
                        }
                    }
                }
            }

            return links;
        }

        public void DeleteLink(int moduleID , int studentID)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string deleteQuery = "delete from StudentModules " +
                                     "WHERE ModuleId = @ModuleID AND StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ModuleID", moduleID);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    int rowsAffected = command.ExecuteNonQuery();
                }

            }

        }

        public void CreateLink(int moduleID, int studentID)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Modules ( StudentID, ModuleID) " +
                                     "VALUES (@StudentID, @ModuleID);" +
                                     "SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ModuleID", moduleID);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    int rowsAffected = command.ExecuteNonQuery();

                }

            }

        }

    }
   
}
