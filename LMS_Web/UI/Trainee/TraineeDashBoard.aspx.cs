using BusinessLayer.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Login;

namespace LMS_Web.UI.Trainee
{
    public partial class TraineeDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string UserId = Session["UserId"].ToString();
            string Role = Session["Role"].ToString();
           
        }



       
    }
}