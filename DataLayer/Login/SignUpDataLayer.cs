using DataModal.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Login
{

   public class SignUpDataLayer
    {
        string connString = @"server=localhost;database=LMS;Integrated Security=True;";
        public void SignUpData(SignUpDataModal signUpDataModal)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SignUp", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@FirstName", SqlDbType.VarChar);
            parameter1.Value = signUpDataModal.First_Name;
            command.Parameters.Add(parameter1);

            SqlParameter parameter2 = new SqlParameter("@LastName", SqlDbType.VarChar);
            parameter2.Value = signUpDataModal.Last_Name;
            command.Parameters.Add(parameter2);


            SqlParameter parameter3 = new SqlParameter("@Mobile_Number", SqlDbType.BigInt);
            parameter3.Value = signUpDataModal.Mobile_Number;
            command.Parameters.Add(parameter3);

            SqlParameter parameter4 = new SqlParameter("@Department", SqlDbType.VarChar);
            parameter4.Value = signUpDataModal.Department;
            command.Parameters.Add(parameter4);

            SqlParameter parameter5 = new SqlParameter("@DOB", SqlDbType.Date);
            parameter5.Value = signUpDataModal.DOB;
            command.Parameters.Add(parameter5);

            SqlParameter parameter6 = new SqlParameter("@Mail_id", SqlDbType.VarChar);
            parameter6.Value = signUpDataModal.Mail_id;
            command.Parameters.Add(parameter6);

            command.ExecuteNonQuery();
            sqlConnection.Close();


        }

        public List<SignUpDataModal> GetUserDetails(SignUpDataModal signUpDataModal)
        {
            List<SignUpDataModal> UserDetails = new List<SignUpDataModal>();
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("FetchUserDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@UserId", SqlDbType.Int);
            parameter1.Value = signUpDataModal.Id;
            command.Parameters.Add(parameter1);

            SqlParameter parameter2 = new SqlParameter("@Role_Name", SqlDbType.VarChar);
            parameter2.Value = signUpDataModal.Role_Name;
            command.Parameters.Add(parameter2);

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    signUpDataModal.First_Name = Convert.ToString(dataReader["FirstName"]);
                    signUpDataModal.Mobile_Number = Convert.ToInt64(dataReader["MobileNumber"]);
                    signUpDataModal.Department = Convert.ToString(dataReader["DepartMent"]);
                    signUpDataModal.Last_Name = Convert.ToString(dataReader["LastName"]);
                    signUpDataModal.Mail_id = Convert.ToString(dataReader["Mail_Id"]);
                    signUpDataModal.DOB = Convert.ToDateTime(dataReader["DOB"]);
                    signUpDataModal.Password = Convert.ToString(dataReader["Password"]);
                    UserDetails.Add(signUpDataModal);
                }
            }
            sqlConnection.Close();
            return UserDetails;
        }
    }
}
