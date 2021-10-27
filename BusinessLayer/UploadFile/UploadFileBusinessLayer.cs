using DataLayer.UploadFile;
using DataModal.UploadFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModal.UploadFile;

namespace BusinessLayer.UploadFile
{
    public class UploadFileBusinessLayer
    {
        public void UploadFile(UploadFileViewModal uploadFileViewModal)
        {
            UploadFileDataLayer uploadDataLayer = new UploadFileDataLayer();
            UploadFileDataModal uploadFileDataModal = new UploadFileDataModal();
            uploadFileDataModal.Name = uploadFileViewModal.Name;
            uploadFileDataModal.Trainer_Id = uploadFileViewModal.Trainer_Id;
            uploadFileDataModal.Type = uploadFileViewModal.Type;
            uploadFileDataModal.Location = uploadFileViewModal.Location;
            uploadFileDataModal.Group_Id = uploadFileViewModal.Group_Id;
            uploadDataLayer.UploadFileData(uploadFileDataModal);
        }
        public string FetchFile(UploadFileViewModal uploadFileViewModal)
        {
            string data = "";
            UploadFileDataLayer uploadFileDataLayer = new UploadFileDataLayer();
            UploadFileDataModal uploadFileDataModal = new UploadFileDataModal();
            uploadFileDataModal.Group_Id = uploadFileViewModal.Group_Id;
            uploadFileDataModal.Type = uploadFileViewModal.Type;
            data = uploadFileDataLayer.GetFilesData(uploadFileDataModal);
            return data;
        }
    }
}
