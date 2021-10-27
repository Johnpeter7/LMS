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
 public   class LoginDataLayer
    {
        string connString = @"server=localhost;database=LMS;Integrated Security=True;";

        public List<LoginDataModal> ValidateUser(LoginDataModal loginDataModal)
        {
            List<LoginDataModal> UserLogin = new List<LoginDataModal>();
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("UserLogin", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@Mail_id", SqlDbType.VarChar);
            parameter1.Value = loginDataModal.Mail_id;
            command.Parameters.Add(parameter1);

            SqlParameter parameter2 = new SqlParameter("@Password", SqlDbType.VarChar);
            parameter2.Value = loginDataModal.Password;
            command.Parameters.Add(parameter2);

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    loginDataModal.Id = Convert.ToInt32(dataReader[0]);
                    loginDataModal.Role_Name = Convert.ToString(dataReader[1]);
                    UserLogin.Add(loginDataModal);
                    //loginData.Id = Convert.ToInt32(dataReader[0]);
                    //loginData.Role = Convert.ToString(dataReader[1]);

                }
            }

            sqlConnection.Close();
            return UserLogin;
        }
        //public string ValidateUser(LoginDataModal loginDataModal)
        //{
           
        //    SqlConnection sqlConnection = new SqlConnection(connString);
        //    sqlConnection.Open();
        //    SqlCommand command = new SqlCommand("UserLogin", sqlConnection);
        //    command.CommandType = CommandType.StoredProcedure;

        //    SqlParameter parameter1 = new SqlParameter("@Mail_id", SqlDbType.VarChar);
        //    parameter1.Value = loginDataModal.Mail_id;
        //    command.Parameters.Add(parameter1);

        //    SqlParameter parameter2 = new SqlParameter("@Password", SqlDbType.VarChar);
        //    parameter2.Value = loginDataModal.Password;
        //    command.Parameters.Add(parameter2);

        //    SqlDataReader dataReader = command.ExecuteReader();

        //    LoginDataModal loginData = new LoginDataModal();
        //    if (dataReader.HasRows)
        //    {
        //        while (dataReader.Read())
        //        {

        //            loginData.Id = Convert.ToInt32(dataReader[0]);
        //            loginData.Role = Convert.ToString(dataReader[1]);
                    
        //        }
        //    }
           
        //        return loginData.ToString();
        //}
    }
}
