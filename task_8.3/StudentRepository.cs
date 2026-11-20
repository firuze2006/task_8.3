using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace task_8._3
{
    public class StudentRepository
    {
        private string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=CourseManagementDB;Integrated Security=True;TrustServerCertificate=True;";

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }

            return students;
        }

        public void Add(Student student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Students
                                (FirstName, LastName, Age, Email)
                                VALUES
                                (@FirstName, @LastName, @Age, @Email)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Email", student.Email);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
