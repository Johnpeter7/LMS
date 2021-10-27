﻿using BusinessLayer.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Login;

namespace LMS_Web.Master_Template.Trainee
{
    public partial class TraineeDashBoard : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string UserId = Session["UserId"].ToString();
            string Role = Session["Role"].ToString();
            FetchUserDetails(UserId, Role);
        }

        private void FetchUserDetails(string userId, string role)
        {
            SignUpBussinessLayer signUpBussinessLayer = new SignUpBussinessLayer();
            List<SignUpViewModal> signUpViewModals = new List<SignUpViewModal>();
            SignUpViewModal signUpViewModal = new SignUpViewModal();
            signUpViewModal.Id = Convert.ToInt32(userId);
            signUpViewModal.Role_Name = Convert.ToString(role);
            signUpViewModals = signUpBussinessLayer.UserDetails(signUpViewModal);
            List<UserDetailsList> userDetail = new List<UserDetailsList>();
            UserDetailsList userDetailsList = new UserDetailsList();
            foreach (var userlist in signUpViewModals)
            {
                userDetailsList.First_Name = userlist.First_Name;
                userDetailsList.Mobile_Number = userlist.Mobile_Number;
                userDetail.Add(userDetailsList);
            }

            lblName.Text = userDetailsList.First_Name;
        }

        protected void btn_LogOut(object sender, EventArgs e)
        {
            Response.Redirect("../../Home.aspx");
        }
    }
}