using BusinessLayer.UploadFile;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.UploadFile;

namespace LMS_Web.UI.Trainee
{
    public partial class ReadingMaterialsData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string getGroupData()
        {
            string data = "";
            string type = Request.QueryString["type"];
            UploadFileBusinessLayer uploadBusinessLayer = new UploadFileBusinessLayer();
            UploadFileViewModal uploadFileViewModal = new UploadFileViewModal();
            uploadFileViewModal.Group_Id =Convert.ToInt32( Session["Group_Id"]);
            uploadFileViewModal.Type = type;
            data = uploadBusinessLayer.FetchFile(uploadFileViewModal);
            return data;

        }
    }
}