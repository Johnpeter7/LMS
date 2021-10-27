using DataModal.Login;
using DataModal.Trainer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;namespace DataLayer.Trainer
{
    public class ManageTraineeDataLayer
    {
        string connString = @"server=localhost;database=LMS;Integrated Security=True;";
        public void AddTraineeData(ManageTraineeDataModal manageTraineeDataModal)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("AddTrainee", sqlConnection);
            command.CommandType = CommandType.StoredProcedure; SqlParameter parameter1 = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameter1.Value = manageTraineeDataModal.First_Name;
            command.Parameters.Add(parameter1); SqlParameter parameter2 = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameter2.Value = manageTraineeDataModal.Last_Name;
            command.Parameters.Add(parameter2); SqlParameter parameter3 = new SqlParameter("@DOB", SqlDbType.Date);
            parameter3.Value = manageTraineeDataModal.DOB;
            command.Parameters.Add(parameter3); SqlParameter parameter4 = new SqlParameter("@MobileNumber", SqlDbType.BigInt);
            parameter4.Value = manageTraineeDataModal.Mobile_Number;
            command.Parameters.Add(parameter4); SqlParameter parameter5 = new SqlParameter("@Email_id", SqlDbType.VarChar);
            parameter5.Value = manageTraineeDataModal.Email;
            command.Parameters.Add(parameter5); SqlParameter parameter6 = new SqlParameter("@Group_Id", SqlDbType.Int);
            parameter6.Value = manageTraineeDataModal.Group_id;
            command.Parameters.Add(parameter6);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateProfile(SignUpDataModal signUpDataModal)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("UpdateTrainee", sqlConnection);
            command.CommandType = CommandType.StoredProcedure; SqlParameter parameter1 = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameter1.Value = signUpDataModal.First_Name;
            command.Parameters.Add(parameter1); SqlParameter parameter2 = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameter2.Value = signUpDataModal.Last_Name;
            command.Parameters.Add(parameter2); SqlParameter parameter3 = new SqlParameter("@MobileNumber", SqlDbType.BigInt);
            parameter3.Value = signUpDataModal.Mobile_Number;
            command.Parameters.Add(parameter3); SqlParameter parameter4 = new SqlParameter("@Department", SqlDbType.VarChar);
            parameter4.Value = signUpDataModal.Department;
            command.Parameters.Add(parameter4); SqlParameter parameter5 = new SqlParameter("@DOB", SqlDbType.Date);
            parameter5.Value = signUpDataModal.DOB;
            command.Parameters.Add(parameter5); SqlParameter parameter6 = new SqlParameter("@Password", SqlDbType.VarChar);
            parameter6.Value = signUpDataModal.Password;
            command.Parameters.Add(parameter6); SqlParameter parameter7 = new SqlParameter("@Mail_Id", SqlDbType.VarChar);
            parameter7.Value = signUpDataModal.Mail_id;
            command.Parameters.Add(parameter7); SqlParameter parameter8 = new SqlParameter("@Id", SqlDbType.VarChar);
            parameter8.Value = signUpDataModal.Id;
            command.Parameters.Add(parameter8); SqlParameter parameter9 = new SqlParameter("@RoleName", SqlDbType.VarChar);
            parameter9.Value = signUpDataModal.Role_Name;
            command.Parameters.Add(parameter9); command.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public List<SignUpDataModal> GetTraineeDetails()
        {
            List<SignUpDataModal> UserDetails = new List<SignUpDataModal>();
            // SignUpDataModal signUpDataModal = new SignUpDataModal(); string connString = @"server=localhost;database=LMS;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GridViewTrainee", sqlConnection);
            command.CommandType = CommandType.StoredProcedure; //SqlParameter parameter1 = new SqlParameter("@Id", SqlDbType.VarChar);
                                                               //parameter1.Value = signUpDataModal.Id;
                                                               //command.Parameters.Add(parameter1);
            SqlDataReader dataReader = command.ExecuteReader();
            //if (dataReader.HasRows)
            // {
            while (dataReader.Read())
            {
                SignUpDataModal signUpDataModal1 = new SignUpDataModal();
                // signUpDataModal1.Id = Convert.ToInt32(dataReader[0]);
                signUpDataModal1.First_Name = Convert.ToString(dataReader[0]);
                signUpDataModal1.Mobile_Number = Convert.ToInt64(dataReader[5]);
                signUpDataModal1.Last_Name = Convert.ToString(dataReader[1]);
                signUpDataModal1.Mail_id = Convert.ToString(dataReader[2]);
                signUpDataModal1.DOB = Convert.ToDateTime(dataReader[3]);
                signUpDataModal1.LastLogin = Convert.ToDateTime(dataReader[4]);
                UserDetails.Add(signUpDataModal1);
            }
            // }
            sqlConnection.Close();
            return UserDetails;
        }
    }
}

