using BusinessLayer.Group;
using DataModal.Group;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Group;

namespace LMS_Web.UserControls
{
    public partial class GroupListView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                    
        }

        public string getGroupData()
        {
            string data = "";
            GroupBussinessLayer groupBussinessLayer = new GroupBussinessLayer();
            GroupViewModal groupViewModal = new GroupViewModal();
            groupViewModal.Trainer_Id=Convert.ToInt32(Session["UserId"]);
            data = groupBussinessLayer.GroupList(groupViewModal);
            return data;

        }
    }
}