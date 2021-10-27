using BusinessLayer.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Group;

namespace LMS_Web.UserControls
{
    public partial class TraineeGroupViewList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string getGroupData()
        {
            string data = "";
            GroupBussinessLayer groupBussinessLayer = new GroupBussinessLayer();
            GroupViewModal groupViewModal = new GroupViewModal();
            groupViewModal.Trainee_Id = Convert.ToInt32(Session["UserId"]) ;
            data = groupBussinessLayer.TraineeGroupList(groupViewModal);
            return data;
        }
    }
}