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
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Students WHERE Number = @Number"; // Replace with your SQL query

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Number",id);

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

                            return student;
                        }
                    }
                }
            }

            return null;
        }

        public Student CreateStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Students (Name, Surname, DateOfBirth, Image, Gender, Phone, Address) " +
                                     "VALUES (@Name, @Surname, @DateOfBirth, @Image, @Gender, @Phone, @Address);" +
                                     "SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Surname", student.Surname);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@Image", new byte[0]);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@Phone", student.Phone);
                    command.Parameters.AddWithValue("@Address", student.Address);

                    int newStudentID = Convert.ToInt32(command.ExecuteScalar());

                    student.Number = newStudentID;

                    // Return the created student
                    return student;
                }
            }
        }

        public void DeleteStudent(int? id)
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();

                string deleteQuery = "delete from StudentModules " +
                                     "WHERE StudentID = @StudentID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", id);

                    int rowsAffected = command.ExecuteNonQuery();


                }



                deleteQuery = "delete from  Students " +
                                     "WHERE Number = @Number";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Number", id);

                    int rowsAffected = command.ExecuteNonQuery();


                }
            }
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
