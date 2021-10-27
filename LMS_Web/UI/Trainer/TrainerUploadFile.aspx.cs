using BusinessLayer.UploadFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.UploadFile;

namespace LMS_Web.UI.Staff
{
    public partial class StaffUploadFile : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile File;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            string Group_Id = Session["Group_Id"].ToString();
            string UserId = Session["UserId"].ToString();
            if (DropDownList1.SelectedIndex != 0)
            {
                if((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
                {
                   
                        string Folder;
                        Folder = DropDownList1.SelectedItem.Text.Trim();
                        var count = 0;
                    string SaveLocation = "";
                        switch (Folder)
                        {

                            case "Video":
                            try
                            {
                                foreach (HttpPostedFile UplodedFile in FileUpload1.PostedFiles)
                                {
                                    string FileName = txtFileName.Text;
                                    SaveLocation = Server.MapPath("../../UploadFiles/" + Group_Id + "/Video") + "\\" + FileName;
                                    UplodedFile.SaveAs(SaveLocation);
                                    count++;
                                }
                                if (count > 0)
                                {
                                    UploadFileViewModal uploadFileViewModal = new UploadFileViewModal();
                                    UploadFileBusinessLayer uploadFileBusinessLayer = new UploadFileBusinessLayer();
                                    uploadFileViewModal.Name = txtFileName.Text;
                                    uploadFileViewModal.Type = DropDownList1.SelectedItem.Text;
                                    uploadFileViewModal.Trainer_Id = UserId;
                                    uploadFileViewModal.Location = SaveLocation.ToString();
                                    uploadFileViewModal.Group_Id = Convert.ToInt32(Group_Id);
                                    uploadFileBusinessLayer.UploadFile(uploadFileViewModal);
                                    Label1.Visible = true;
                                    Label1.Text = count + "-Files Uploaded..!!";
                                }
                            }
                            catch (Exception)
                            {

                                if ((System.IO.File.Exists(SaveLocation)))
                                {
                                    System.IO.File.Delete(SaveLocation);
                                }
                                Label1.Visible = true;
                                Label1.Text = "Not Uploaded..!!";
                            }
                              
                          
                                break;

                            case "Image":
                            try
                            {
                                foreach (HttpPostedFile UplodedFile in FileUpload1.PostedFiles)
                                {
                                    string FileName = System.IO.Path.GetFileName(txtFileName.Text);
                                    SaveLocation = Server.MapPath("../../UploadFiles/" + Group_Id + "/Image") + "\\" + FileName;
                                    UplodedFile.SaveAs(SaveLocation);
                                    count++;
                                }
                                if (count > 0)
                                {

                                    UploadFileViewModal uploadFileViewModal = new UploadFileViewModal();
                                    UploadFileBusinessLayer uploadFileBusinessLayer = new UploadFileBusinessLayer();
                                    uploadFileViewModal.Name = txtFileName.Text;
                                    uploadFileViewModal.Type = DropDownList1.SelectedItem.Text;
                                    uploadFileViewModal.Trainer_Id = UserId;
                                    uploadFileViewModal.Location = SaveLocation.ToString();
                                    uploadFileViewModal.Group_Id = Convert.ToInt32(Group_Id);
                                    uploadFileBusinessLayer.UploadFile(uploadFileViewModal);
                                    Label1.Visible = true;
                                    Label1.Text = count + "-Files Uploaded..!!";
                                }
                            }
                            catch (Exception)
                            {
                                if ((System.IO.File.Exists(SaveLocation)))
                                {
                                    System.IO.File.Delete(SaveLocation);
                                }
                                Label1.Visible = true;
                                Label1.Text = "Not Uploaded..!!";
                            }
                                
                             break;
                            case "PDF":
                            try
                            {
                                foreach (HttpPostedFile UplodedFile in FileUpload1.PostedFiles)
                                {
                                    string FileName = System.IO.Path.GetFileName(txtFileName.Text);
                                    SaveLocation = Server.MapPath("../../UploadFiles/" + Group_Id + "/PDF") + "\\" + FileName;
                                    UplodedFile.SaveAs(SaveLocation);
                                    count++;
                                }
                                if (count > 0)
                                {

                                    UploadFileViewModal uploadFileViewModal = new UploadFileViewModal();
                                    UploadFileBusinessLayer uploadFileBusinessLayer = new UploadFileBusinessLayer();
                                    uploadFileViewModal.Name = txtFileName.Text;
                                    uploadFileViewModal.Type = DropDownList1.SelectedItem.Text;
                                    uploadFileViewModal.Trainer_Id = UserId;
                                    uploadFileViewModal.Location = SaveLocation.ToString();
                                    uploadFileViewModal.Group_Id = Convert.ToInt32(Group_Id);
                                    uploadFileBusinessLayer.UploadFile(uploadFileViewModal);
                                    Label1.Visible = true;
                                    Label1.Text = count + "-Files Uploaded..!!";
                                }

                            }
                            catch (Exception)
                            {

                                if ((System.IO.File.Exists(SaveLocation)))
                                {
                                    System.IO.File.Delete(SaveLocation);
                                }
                                Label1.Visible = true;
                                Label1.Text = "Not Uploaded..!!";
                            }
                            break;
                        }
                  
                       
           
                   
                }
                else
                {
                    Label1.Visible = true;
                    Label1.Text = "Unable to Uploaded..!!";
                }
            }
        }
    }
}