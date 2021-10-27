using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;


namespace LMS_Web.UI.Trainee
{
    public partial class ReadingMaterialDataView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var Location1 = Request.QueryString["Location"];
            //string Location = "C:\\Users\\magendran.gs\\source\\repos\\LMS_Web\\LMS_Web\\UploadFiles\\1\\Video\\C#Part1";
            Process.Start("firefox.exe", Location1);
            //object fileSavePath = Location;
            //Process.Start(Loaction);
            //Application applicationclass = new Application();
            //applicationclass.Documents.Open(ref fileSavePath);
            //applicationclass.Visible = false;
            //Document document = applicationclass.ActiveDocument;
            //this.Application.Documents.Open(@"C:\Test\NewDocument.docx", ReadOnly: true);
            
            //string FilePath = Server.MapPath(Loaction);
            //WebClient User = new WebClient();
            //Byte[] FileBuffer = User.DownloadData(Loaction);
            //if (FileBuffer != null)
            //{
            //    Response.ContentType = "application/pdf";
            //    Response.AddHeader("content-length", FileBuffer.Length.ToString());
            //    Response.BinaryWrite(FileBuffer);
            //}
        }
    }
}