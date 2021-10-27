using BusinessLayer.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Trainer;

namespace LMS_Web.UI.Trainer
{
    public partial class AddTrainee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string Group_Id = Session["Group_Id"].ToString();
            ManageTraineeViewModal manageTraineeViewModal = new ManageTraineeViewModal();
            manageTraineeViewModal.First_Name = txtFirstName.Text;
            manageTraineeViewModal.Last_Name = txtLastName.Text;
            manageTraineeViewModal.Mobile_Number = Convert.ToInt64(txtMobile_No.Text);
            manageTraineeViewModal.DOB = Convert.ToDateTime(txtDOB.Text);
            manageTraineeViewModal.Email = txtEmail.Text;
            manageTraineeViewModal.Group_id =Convert.ToInt32( Group_Id);
            ManageTraineeBusinessLayer manageTraineeBusinessLayer = new ManageTraineeBusinessLayer();
            manageTraineeBusinessLayer.AddTrainee(manageTraineeViewModal);
            lblMessage.Visible = true;
            lblMessage.Text = "Trainee Enrolled..!!";
        }
    }
}