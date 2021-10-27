using BusinessLayer.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Group;

namespace LMS_Web.UI.Trainer
{
    public partial class CreateGroups : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string newDirectory;
                string subDirectory1 = "PDF", subDirectory2 = "Video", subDirectory3 = "Image";
                int Group_Id = 0;
                GroupBussinessLayer groupBussinessLayer = new GroupBussinessLayer();
                GroupViewModal groupViewModal = new GroupViewModal();
                groupViewModal.Title = txtTitle.Text;
                groupViewModal.Description = txtDesc.Text;
                groupViewModal.Trainer_Id = Convert.ToInt32(Session["UserId"]);
                Group_Id = groupBussinessLayer.GroupCreation(groupViewModal);
                newDirectory = Convert.ToString(Group_Id);
                System.IO.Directory.CreateDirectory(MapPath("../../UploadFiles" + "\\" + newDirectory));
                System.IO.Directory.CreateDirectory(MapPath("../../UploadFiles" + "\\" + newDirectory + "\\" + subDirectory1));
                System.IO.Directory.CreateDirectory(MapPath("../../UploadFiles" + "\\" + newDirectory + "\\" + subDirectory2));
                System.IO.Directory.CreateDirectory(MapPath("../../UploadFiles" + "\\" + newDirectory + "\\" + subDirectory3));
            }
            catch (Exception)
            {
                Label1.Visible = true;
                Label1.Text = "Error..!!";
            }
            finally
            {
                Response.Redirect("TrainerDashBoard.aspx");
            }
          


        }
    }
}
