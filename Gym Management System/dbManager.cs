
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Gym_Management_System
{
   
    public class dbManager
    {
        private string connectionString;

        public dbManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void RegisterMember(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO tblMember (ID,Name,Address,Phone,Gender,RegFee,DateOfBirth,RegDate)  VALUES (@ID,@Name,@Address,@Phone,@Gender,@RegFee,@DateOfBirth,@RegDate)";
                SqlCommand command = new SqlCommand(query, connection);
                 command.Parameters.AddWithValue("@ID", person.Id);
                 command.Parameters.AddWithValue("@Name", person.Name);
                 command.Parameters.AddWithValue("@Address", person.Address);
                 command.Parameters.AddWithValue("@Phone", person.Phone);
                 command.Parameters.AddWithValue("@Gender", person.Gender);
                 command.Parameters.AddWithValue("@RegFee", person.RegFee);
                 command.Parameters.AddWithValue("@DateOfBirth", person.Dob);
                command.Parameters.AddWithValue("@RegDate", DateTime.Now.ToString("yyyy/MM/dd"));
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        /*................................update member**************************************/

        public void UpdateMember(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblMember SET Name = @Name, Address = @Address,Phone=@Phone,Gender=@Gender,RegFee=@RegFee,DateOfBirth=@DateOfBirth WHERE ID = @ID"; // Replace with your table name

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", person.Id);
                command.Parameters.AddWithValue("@Name", person.Name);
                command.Parameters.AddWithValue("@Address", person.Address);
                command.Parameters.AddWithValue("@Phone", person.Phone);
                command.Parameters.AddWithValue("@Gender", person.Gender);
                command.Parameters.AddWithValue("@RegFee", person.RegFee);
                command.Parameters.AddWithValue("@DateOfBirth", person.Dob);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteMember(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tblMember WHERE ID = @ID"; // Replace with your table name

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID",person.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteTrainer(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tblTrainer WHERE t_ID = @t_ID"; // Replace with your table name

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@t_ID", person.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RegisterTrainer(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO tblTrainer (t_ID,t_Name,t_Address,t_Phone,t_Gender,t_RegFee,DateOfBirth,RegDate)  VALUES (@t_ID,@t_Name,@t_Address,@t_Phone,@t_Gender,@t_RegFee,@DateOfBirth,@RegDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@t_ID", person.Id);
                command.Parameters.AddWithValue("@t_Name", person.Name);
                command.Parameters.AddWithValue("@t_Address", person.Address);
                command.Parameters.AddWithValue("@t_Phone", person.Phone);
                command.Parameters.AddWithValue("@t_Gender", person.Gender);
                command.Parameters.AddWithValue("@t_RegFee", person.RegFee);
                command.Parameters.AddWithValue("@DateOfBirth", person.Dob);
                command.Parameters.AddWithValue("@RegDate", DateTime.Now.ToString("yyyy/MM/dd"));
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public void UpdateTrainer(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE tblTrainer SET t_Name = @t_Name, t_Address = @t_Address,t_Phone=@t_Phone,t_Gender=@t_Gender,t_RegFee=@t_RegFee,DateOfBirth=@DateOfBirth WHERE t_ID = @t_ID"; // Replace with your table name

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@t_ID", person.Id);
                command.Parameters.AddWithValue("@t_Name", person.Name);
                command.Parameters.AddWithValue("@t_Address", person.Address);
                command.Parameters.AddWithValue("@t_Phone", person.Phone);
                command.Parameters.AddWithValue("@t_Gender", person.Gender);
                command.Parameters.AddWithValue("@t_RegFee", person.RegFee);
                command.Parameters.AddWithValue("@DateOfBirth", person.Dob);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public DataTable GetMember()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tblMember";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }

        ///  Get Member ID///
        public DataTable GetMemberID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID FROM tblMember WHERE ID=@ID";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }



        public DataTable GetTrainer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tblTrainer";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }

        ///////////////////////////////////attendance///////////////////////////////////////
        public void memAttendance(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO  tblMemAttend (MemberID,Date,Month)  VALUES (@MemberID,@Date,@Month)";
                SqlCommand command = new SqlCommand(query, connection);
                // command.Parameters.AddWithValue("@AttendanceID", 100);
                command.Parameters.AddWithValue("@MemberID", person.Id);
                command.Parameters.AddWithValue("@Date", person.Date);
                command.Parameters.AddWithValue("@Month", person.Month);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }
        public void trainAttendance(Person person)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "INSERT INTO  tblTrainAttend (TrainerID,Date,Month)  VALUES (@TrainerID,@Date,@Month)";
                SqlCommand command = new SqlCommand(query, connection);
                // command.Parameters.AddWithValue("@AttendanceID", 100);
                command.Parameters.AddWithValue("@TrainerID", person.Id);
                command.Parameters.AddWithValue("@Date", person.Date);
                command.Parameters.AddWithValue("@Month", person.Month);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }




    }
}
