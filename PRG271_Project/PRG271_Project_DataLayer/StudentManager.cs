using PRG271_Project_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Students"; // Replace with your SQL query

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                Number = (int)reader["Number"],
                                Name = reader["Name"].ToString(),
                                Surname = reader["Surname"].ToString(),
                                DateOfBirth = (DateTime)reader["DateOfBirth"],
                                Image = reader["Image"] as byte?,
                                Gender = reader["Gender"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Address = reader["Address"].ToString(),
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
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
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Students " +
                                     "SET Name = @Name, " +
                                     "    Surname = @Surname, " +
                                     "    DateOfBirth = @DateOfBirth, " +
                                     "    Image = @Image, " +
                                     "    Gender = @Gender, " +
                                     "    Phone = @Phone, " +
                                     "    Address = @Address " +
                                     "WHERE Number = @Number";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Surname", student.Surname);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);

                    //TODO: handle Images
                    command.Parameters.AddWithValue("@Image", new byte[0]);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@Phone", student.Phone);
                    command.Parameters.AddWithValue("@Address", student.Address);
                    command.Parameters.AddWithValue("@Number", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return student;
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
