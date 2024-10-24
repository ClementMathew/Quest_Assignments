using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patient_and_Doctor_Management_System.Models;
using Patient_and_Doctor_Management_System.Settings;
using static Patient_and_Doctor_Management_System.Models.GenderType;
using Patient_and_Doctor_Management_System.Models.Types;
using static Patient_and_Doctor_Management_System.Models.Types.SpecializationType;
using System.Xml.Linq;

namespace Patient_and_Doctor_Management_System.Repositories
{
    internal class DoctorRepository
    {
        private SqlConnection _connection;

        public DoctorRepository()
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

        public void Create(Doctor doctor)
        {
            ConnectionCheck();

            var sql = "INSERT INTO Doctor (Name, Specialization, PatientId) VALUES (@Name, @Specialization,@PatientId)";
            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@Name", doctor.Name);
            command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
            command.Parameters.AddWithValue("@PatientId", doctor.PatientId);

            command.ExecuteNonQuery();
        }

        public List<Doctor> View()
        {
            ConnectionCheck();

            var sql = "SELECT Name, Specialization, PatientId FROM Doctor";

            var command = new SqlCommand(sql, _connection);

            var reader = command.ExecuteReader();

            var doctors = new List<Doctor>();

            while (reader.Read())
            {
                doctors.Add(new Doctor
                {
                    Name = (string)reader["Name"],
                    Specialization = (Specializations)reader["Specialization"],
                    PatientId = (int)reader["PatientId"]
                });
            }
            return doctors;
        }

        public void Update(int id, string name)
        {
            string sql = "UPDATE Doctor SET Name=@Name WHERE Id=@Id";

            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM Doctor WHERE Id=@Id";

            var command = new SqlCommand(sql, _connection);

            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }
}
