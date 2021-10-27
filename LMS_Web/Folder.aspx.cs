using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS_Web
{
    public partial class Folder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string newDirectory;
            string subDirectory1="PDF", subDirectory2="Video", subDirectory3="Docs";
            newDirectory = TextBox1.Text;
            System.IO.Directory.CreateDirectory(MapPath("UploadFiles" + "\\"+newDirectory));
            System.IO.Directory.CreateDirectory(MapPath("UploadFiles" + "\\" + newDirectory+"\\"+ subDirectory1));
            System.IO.Directory.CreateDirectory(MapPath("UploadFiles" + "\\" + newDirectory + "\\" + subDirectory2));
            System.IO.Directory.CreateDirectory(MapPath("UploadFiles" + "\\" + newDirectory + "\\" + subDirectory3));

        }
    }
}