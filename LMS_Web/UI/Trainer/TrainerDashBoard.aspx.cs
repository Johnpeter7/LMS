using BusinessLayer.Login;
using DataModal.Group;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Login;

namespace LMS_Web.UI.Staff
{
    public partial class StaffDashBoard : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string UserId = Session["UserId"].ToString();
            string Role = Session["Role"].ToString();
            FetchUserDetails(UserId,Role);
        }
        public string getGroupData()
        {
            string data = "";
            GroupDataModal groupDataModal = new GroupDataModal();
            List<GroupDataModal> GroupDetails = new List<GroupDataModal>();
            string connString = @"server=localhost;database=LMS;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("FetchGroupList", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    groupDataModal.Title = Convert.ToString(dataReader[1]);
                    groupDataModal.Description = Convert.ToString(dataReader[3]);
                    data += " <div class='w3 - panel w3 - round w3 - card - 4  w3 - white>" +
                        "<h4>" +groupDataModal.Title+
                        "</h4>" +
                        "<p>" +groupDataModal.Description+
                        "</p>" +
                        "</div>";
                    //data += " <div class='w3 - panel w3 - round w3 - card - 4  w3 - white'><h4> " + groupDataModal.Title + "</h4>" + "<h6>" + groupDataModal.Description + "<h6>" + "</div>";
                    //data += "<h4>" + groupDataModal.Title + "</h4>" + "<h6>" + groupDataModal.Description + "</h6>";

                }
            }
            return data;
            
        }

        private void FetchUserDetails(string userId, string Role)
        {
            //SignUpBussinessLayer signUpBussinessLayer = new SignUpBussinessLayer();
            //List<SignUpViewModal> signUpViewModals = new List<SignUpViewModal>();
            //SignUpViewModal signUpViewModal = new SignUpViewModal();
            //signUpViewModal.Id = Convert.ToInt32(userId);
            //signUpViewModal.Role_Name = Convert.ToString(Role);
            //signUpViewModals = signUpBussinessLayer.UserDetails(signUpViewModal);
            //List<UserDetailsList> userDetail = new List<UserDetailsList>();
            //UserDetailsList userDetailsList = new UserDetailsList();
            //foreach (var userlist in signUpViewModals)
            //{
            //    userDetailsList.First_Name = userlist.First_Name;
            //    userDetailsList.Mobile_Number = userlist.Mobile_Number;
            //    userDetail.Add(userDetailsList);
            //}
            //Label1.Text = userDetailsList.First_Name;



        }

        protected void btn_LogOut(object sender, EventArgs e)
        {
            Response.Redirect("../../Home.aspx");
        }
    }
}