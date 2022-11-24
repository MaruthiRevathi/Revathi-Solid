using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingMgmt.Repositories.Interfaces;
using TrainingMgmt.Repositories.Models;
using System.Data.SqlClient;

namespace TrainingMgmt.Repositories.AdoNet.Implementation
{
    public class AdoNetStudentRepository : IStudentRepository
    {
        public Student Add(Student student)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetList()
        {
            List<Student> students = new List<Student>();
            string cs = @"Server=(local);Database=ABCTraining;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(cs);
            string query = "SELECT * FROM dbo.Student";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student student = new Student();
                student.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                student.Name = reader.GetString(reader.GetOrdinal("Name"));
                student.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                student.City = reader.GetString(reader.GetOrdinal("City"));
                student.Mail = reader.GetString(reader.GetOrdinal("Mail"));

                students.Add(student);
            }

            connection.Close();

            return students;
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
