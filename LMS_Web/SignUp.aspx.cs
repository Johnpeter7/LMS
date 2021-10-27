using BusinessLayer.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Login;

namespace LMS_Web
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SignUpViewModal signUpViewModal = new SignUpViewModal();
            signUpViewModal.First_Name = txtFirstName.Text;
            signUpViewModal.Last_Name = txtLastName.Text;
            signUpViewModal.Mobile_Number = Convert.ToInt64(txtMobile.Text);
            signUpViewModal.Mail_id = txtEmail.Text;
            signUpViewModal.DOB = Convert.ToDateTime(txtDOB.Text);
            signUpViewModal.Department = DropDownList1.SelectedItem.Text;
            SignUpBussinessLayer signUpBussinessLayer = new SignUpBussinessLayer();
            signUpBussinessLayer.SignUp(signUpViewModal);
            Response.Redirect("Home.aspx");
        }
    }
}