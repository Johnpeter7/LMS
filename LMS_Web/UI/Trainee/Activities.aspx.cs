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
    public partial class Activities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public string getAssesmentResult()
        {
            string data = "";
            AssesmentResult assesmentResult = new AssesmentResult();
           
            assesmentResult.trainee_id =Convert.ToInt32(Session["UserId"]);
            AssesmentBusinessLayer assesmentBusinessLayer = new AssesmentBusinessLayer();
            data = assesmentBusinessLayer.FetchResult(assesmentResult);
            return data;

        }


    }
}