using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_and_Doctor_Management_System.Settings;
using Patient_and_Doctor_Management_System.Models;
using static Patient_and_Doctor_Management_System.Models.GenderType;
using System.Globalization;

namespace Patient_and_Doctor_Management_System.Repositories
{
    internal class PatientRepository
    {
        private SqlConnection _connection;

        public PatientRepository()
        {
            _connection = new SqlConnection(AppSettings.ConnectionString);
        }

        private void ConnectionCheck()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void Create(Patient patient)
        {
            ConnectionCheck();

            var sql = "INSERT INTO Patient (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@Name", patient.Name);
            command.Parameters.AddWithValue("@Age", patient.Age);
            command.Parameters.AddWithValue("@Gender", patient.Gender);
            command.Parameters.AddWithValue("@MedicalCondition", patient.MedicalCondition);

            command.ExecuteNonQuery();
        }

        public List<Patient> View()
        {
            ConnectionCheck();

            var sql = "SELECT Name, Age, Gender, MedicalCondition FROM Patient";
            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            var patients = new List<Patient>();

            while (reader.Read())
            {
                patients.Add(new Patient
                {
                    Name = (string)reader["Name"],
                    Age = (int)reader["Age"],
                    Gender = (Gender)reader["Gender"],
                    MedicalCondition = (string)reader["MedicalCondition"]
                });
            }
            return patients;
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM Patient WHERE Id=@Id";
            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public void Update(int id, string name, int age, string medicalCondition)
        {
            string sql = "UPDATE Patient SET Name=@Name, Age=@Age, MedicalCondition=@MedicalCondition WHERE Id=@Id";

            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Age", age);
            command.Parameters.AddWithValue("@MedicalCondition", medicalCondition);

            command.ExecuteNonQuery();
        }
    }
}
