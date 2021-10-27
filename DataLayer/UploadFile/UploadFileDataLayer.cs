using DataModal.UploadFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UploadFile
{
    public class UploadFileDataLayer
    {
        string connString = @"server=localhost;database=LMS;Integrated Security=True;";
        public void UploadFileData(UploadFileDataModal uploadFileDataModal)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("UploadFileData", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter("@FileName", SqlDbType.VarChar);
                parameter1.Value = uploadFileDataModal.Name;
                command.Parameters.Add(parameter1);

                SqlParameter parameter2 = new SqlParameter("@Type", SqlDbType.VarChar);
                parameter2.Value = uploadFileDataModal.Type;
                command.Parameters.Add(parameter2);


                SqlParameter parameter3 = new SqlParameter("@Location", SqlDbType.VarChar);
                parameter3.Value = uploadFileDataModal.Location;
                command.Parameters.Add(parameter3);


                SqlParameter parameter4 = new SqlParameter("@TrainerId", SqlDbType.Int);
                parameter4.Value = uploadFileDataModal.Trainer_Id;
                command.Parameters.Add(parameter4);

                SqlParameter parameter5 = new SqlParameter("@GroupId", SqlDbType.Int);
                parameter5.Value = uploadFileDataModal.Group_Id;
                command.Parameters.Add(parameter5);

                command.ExecuteNonQuery();
            }
            catch (SqlException )
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
           



        }
        public string GetFilesData(UploadFileDataModal uploadFileDataModal)
        {
            string data = "";
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("FetchFiles", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter2 = new SqlParameter("@Type", SqlDbType.Int);
                parameter2.Value = uploadFileDataModal.Type;
                command.Parameters.Add(parameter2);

                SqlParameter parameter3 = new SqlParameter("@Group_Id", SqlDbType.Int);
                parameter3.Value = uploadFileDataModal.Group_Id;
                command.Parameters.Add(parameter3);

                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        uploadFileDataModal.Name = Convert.ToString(dataReader[1]);
                        uploadFileDataModal.Date = Convert.ToDateTime(dataReader[6]);
                        uploadFileDataModal.Location = Convert.ToString(dataReader[3]);
                        data += " <a class='Panel_a' style=' text-decoration:none;' href='ReadingMaterialDataView.aspx?Location=" + uploadFileDataModal.Location + "'><div class='Panel'><h4> " + uploadFileDataModal.Name + "</h4>" +
                           "<h6>" + uploadFileDataModal.Date + "<h6>" + "</div>";
                    }
                }
                return data;
            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }
    }
}
