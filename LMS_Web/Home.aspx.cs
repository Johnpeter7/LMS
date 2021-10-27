using BusinessLayer.Login;
using DataModal.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Login;

namespace LMS_Web
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int User_Id=0;
            string Role = "";
            LoginBusinessLayer loginBusinessLayer = new LoginBusinessLayer();
            List<LoginViewModal> loginViewModals = new List<LoginViewModal>();
            LoginViewModal loginViewModal = new LoginViewModal();
            loginViewModal.Mail_id = txtMailId.Text;
            loginViewModal.Password = txtPassword.Text;
            loginViewModals = loginBusinessLayer.UserLogin(loginViewModal);
            List<LoginList> loginLists = new List<LoginList>();
            LoginList loginList = new LoginList();
            foreach (var userlist in loginViewModals)
            {
               
                loginList.Id = userlist.Id;
                loginList.Role_Name = userlist.Role_Name;
                loginLists.Add(loginList);
            }

            Role = loginList.Role_Name;
            User_Id = loginList.Id;
            UserRedirect(Role, User_Id);
            




        }

        private void UserRedirect(string role, int user_Id)
        {
          if(role== "TRAINER")
            {
                //lblMessage.Visible = true;
                //lblMessage.Text = "Login Succesfully..!!";
                Session["UserId"] = user_Id;
                Session["Role"] = role;
                Response.Redirect("UI/Trainer/TrainerDashBoard.aspx");
                //Response.Write("<script>alert('Login successfully..!!')</script>");
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
            }
            else if(role== "TRAINEE")
            {
                Session["UserId"] = user_Id;
                Session["Role"] = role;
                Response.Redirect("UI/Trainee/TraineeDashBoard.aspx");
                //Response.Write("<script>alert('Login successfully..!!')</script>");
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
            }
            else
            {
                lblMessage.Visible = true;
                lblMessage.Text = "please check UserName and Password!!";
            }
        }

        //public string GetLoginValidation()
        //{
        //    string data = "";
        //    LoginViewModal loginViewModal = new LoginViewModal();
        //    loginViewModal.Mail_id = Convert.ToString(txtMailId.Text);
        //    loginViewModal.Password = Convert.ToString(txtPassword.Text);
        //    LoginBusinessLayer loginBusinessLayer = new LoginBusinessLayer();
        //    data=  loginBusinessLayer.UserLogin(loginViewModal);
        //    return data;

        //}

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}