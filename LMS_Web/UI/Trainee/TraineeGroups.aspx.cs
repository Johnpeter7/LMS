﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS_Web.UI.Trainee
{
    public partial class TraineeGroups : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Group_Id = Request.QueryString["GroupId"];
            Session["Group_Id"] = Group_Id;

        }
    }
}