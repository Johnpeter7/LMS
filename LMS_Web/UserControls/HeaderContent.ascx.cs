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
    public partial class HeaderContent : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Group_Id = Session["Group_Id"].ToString();
            FetchGroupInfo(Group_Id);
        }

        private void FetchGroupInfo(string group_Id)
        {
            GroupBussinessLayer groupBussinessLayer = new GroupBussinessLayer();
            List<GroupViewModal> groupViewModals = new List<GroupViewModal>();
            GroupViewModal groupViewModal = new GroupViewModal();
            groupViewModal.Group_Id = Convert.ToInt32(group_Id);
            groupViewModals = groupBussinessLayer.GroupInfo(groupViewModal);
            //List<GroupInfoView> groupInfoViews = new List<GroupInfoView>();
            GroupInfoView groupInfoView = new GroupInfoView();
            foreach (var item in groupViewModals)
            {
                groupInfoView.Title = item.Title;
                groupInfoView.Description = item.Description;
                groupInfoView.date = item.date;
                //groupInfoViews.Add(groupInfoView);
            }
            lblTitle.Text = Convert.ToString(groupInfoView.Title);

            lblDate.Text = Convert.ToString(groupInfoView.date);
            lblDescripton.Text = Convert.ToString(groupInfoView.Description);
        }
    }
}