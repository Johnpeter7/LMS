using BusinessLayer.Login;
using BusinessLayer.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Login;
using ViewModal.Trainer;namespace LMS_Web.UI.Trainer
{
    public partial class TraineeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FetchTraineeDetrails();
        }
        protected void GridDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }
        private void FetchTraineeDetrails()
        {
            ManageTraineeBusinessLayer manageTraineeBusinessLayer = new ManageTraineeBusinessLayer();
            List<SignUpViewModal> signUpViewModals = new List<SignUpViewModal>();
            SignUpViewModal signUpViewModal = new SignUpViewModal();
            signUpViewModals = manageTraineeBusinessLayer.GetTraineeDetails();
            List<GridTraineDetails> userDetail = new List<GridTraineDetails>();
            foreach (var userlist in signUpViewModals)
            {
                GridTraineDetails userDetailsList = new GridTraineDetails();
                userDetailsList.First_Name = userlist.First_Name;
                userDetailsList.Mobile_Number = userlist.Mobile_Number;
                userDetailsList.Last_Name = userlist.Last_Name;
                userDetailsList.Mail_id = userlist.Mail_id;
                userDetailsList.DOB = userlist.DOB;
                userDetailsList.LastLogin = userlist.LastLogin; userDetail.Add(userDetailsList);
            }
            GridView1.DataSource = userDetail;
            GridView1.DataBind();
        }
    }
}

