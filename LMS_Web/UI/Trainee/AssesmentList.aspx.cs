using BusinessLayer.Assesment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Assement;

namespace LMS_Web.UI.Trainee
{
    public partial class AssesmentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string getAssesmentList()
        {
            string data = "";
            AssesmentViewModal assesmentViewModal = new AssesmentViewModal();
            assesmentViewModal.Group_Id = Convert.ToInt32(Session["Group_Id"]);
            AssesmentBusinessLayer assesmentBusinessLayer = new AssesmentBusinessLayer();
           data= assesmentBusinessLayer.AssesmentList(assesmentViewModal);
            return data;

        }
    }
}