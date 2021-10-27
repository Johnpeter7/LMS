using BusinessLayer.Login;
using BusinessLayer.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Login;
using ViewModal.Trainer;

namespace LMS_Web.UI.Trainer
{
    public partial class TrainerProfile : System.Web.UI.Page
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
            signUpViewModal.Role_Name = role;
            signUpViewModals = signUpBussinessLayer.UserDetails(signUpViewModal);
            List<UserDetailsList> userDetail = new List<UserDetailsList>();
            UserDetailsList userDetailsList = new UserDetailsList();
            foreach (var userlist in signUpViewModals)
            {
                userDetailsList.First_Name = userlist.First_Name;
                userDetailsList.Mobile_Number = userlist.Mobile_Number;
                userDetailsList.Last_Name = userlist.Last_Name;
                userDetailsList.Mail_id = userlist.Mail_id;
                userDetailsList.Password = userlist.Password;
                userDetailsList.Department = userlist.Department;
                userDetailsList.DOB = userlist.DOB;

                userDetail.Add(userDetailsList);
            }
            lblFirstName.Text = userDetailsList.First_Name;
            lblMobileNumber.Text = userDetailsList.Mobile_Number.ToString();
            lblDepartment.Text = userDetailsList.Department;
            lblDOB.Text =userDetailsList.DOB.ToString();
            lblLastName.Text = userDetailsList.Last_Name;
            lblEmail.Text = userDetailsList.Mail_id;
            lblPassword.Text = userDetailsList.Password;
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

            Panel1.Visible = false;
            Panel2.Visible = true;
            txtFirstName.Text = lblFirstName.Text;
            txtLastName.Text = lblLastName.Text;
            txtMobileNumber.Text = lblMobileNumber.Text;
            txtPassword.Text = lblPassword.Text;
            txtEmail.Text = lblEmail.Text;
            txtDOB.Text = lblDOB.Text;
            


            //string UserId = Session["UserId"].ToString();
            //string Role = Session["Role"].ToString();
            //FetchUserDetails(UserId, Role);
            //btnEdit.Visible = false;
            //txtDepartment.Visible = false;
            //DropDownList1.Visible = true;
            //btnUpdate.Visible = true;

            //txtFirstName.ReadOnly = false;
            //txtLastName.ReadOnly = false;
            //txtMobileNumber.ReadOnly = false;
            //txtDepartment.ReadOnly = false;
            //txtDOB.ReadOnly = false;
            //txtEmail.ReadOnly = false;
            //txtPassword.ReadOnly = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            string UserId = Session["UserId"].ToString();
            string Role = Session["Role"].ToString();
            ManageTraineeBusinessLayer manageTraineeBusinessLayer = new ManageTraineeBusinessLayer();
            SignUpViewModal manageTraineeViewModal = new SignUpViewModal();
            manageTraineeViewModal.First_Name = txtFirstName.Text;
            manageTraineeViewModal.Last_Name = txtLastName.Text;
            manageTraineeViewModal.Mobile_Number = Convert.ToInt64(txtMobileNumber.Text);
            manageTraineeViewModal.Department = DropDownList1.SelectedItem.Text;
            manageTraineeViewModal.DOB = Convert.ToDateTime(txtDOB.Text);
            manageTraineeViewModal.Mail_id = txtEmail.Text;
            manageTraineeViewModal.Password = txtPassword.Text;
            manageTraineeViewModal.Role_Name = Role;
            manageTraineeViewModal.Id = Convert.ToInt32(UserId);
            manageTraineeBusinessLayer.UpdateTrainer(manageTraineeViewModal);
            lblMessage.Visible = true;
            lblMessage.Text = "Updated Successfully..!!";
            Response.Redirect("TrainerProfile.aspx");



        }

        protected void btnUpdate_Click2(object sender, EventArgs e)
        {
            //Label1.Visible = true;
            //Label1.Text = TextBox1.Text;
        }

        protected void btnEdit_Click1(object sender, EventArgs e)
        {

        }
    }
}