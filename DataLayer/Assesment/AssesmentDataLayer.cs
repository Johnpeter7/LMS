using DataModal.Assesment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModal.Assement;

namespace DataLayer.Assesment
{
   public class AssesmentDataLayer
    {
        string connString = @"server=localhost;database=LMS;Integrated Security=True;";

        public string FetchResult(AssesmentResultDataModal assesmentResultDataModal)
        {
            string data = "";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("FetchResults", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            

            SqlParameter parameter2 = new SqlParameter("@TraineeId", SqlDbType.Int);
            parameter2.Value = assesmentResultDataModal.trainee_id;
            command.Parameters.Add(parameter2);

            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    assesmentResultDataModal.Title = sqlDataReader[0].ToString();
                    assesmentResultDataModal.Date = Convert.ToDateTime(sqlDataReader[1]);
                    assesmentResultDataModal.marks = Convert.ToInt32(sqlDataReader[4]);
                    assesmentResultDataModal.Counts = Convert.ToInt32(sqlDataReader[5]);
                    data += "<div class='Panel' >" +
                        "<span class='dot'><h2 style='margin - top:30px; color:#00cc00;'>" + assesmentResultDataModal.marks+"/"+ assesmentResultDataModal.Counts+"</h2></span>" +
                        "<p>"+ assesmentResultDataModal.Title+"</p>" +
                        "<p>"+ assesmentResultDataModal.Date+"</p>" +
                        "</div> ";
                        
           
                }
            }
            else
            {
                string msg1 = "No Data Found";
                data += " <a class='Panel_a' style=' text-decoration:none;' href='#'><div class='Panel'><h4  style='  text-align: center;' > " + msg1 + "</h4>" + "</div>";
            }

            return data;
        }
        public List<AssesmentDataModal>  FetchAssesmentData(AssesmentDataModal assesmentDataModal)
        {
            List<AssesmentDataModal> assesmentDataModals = new List<AssesmentDataModal>();
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("FetchAssesmentData", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@AssesmentId", SqlDbType.Int);
            parameter1.Value = assesmentDataModal.Assesment_Id;
            command.Parameters.Add(parameter1);

            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    assesmentDataModal.Title = sqlDataReader["TITLE"].ToString();
                    assesmentDataModal.counts = Convert.ToInt32(sqlDataReader["count"]);
                    assesmentDataModals.Add(assesmentDataModal);

                }
              
            }
            return assesmentDataModals;
        }
        public string AssesmentList(AssesmentDataModal assesmentDataModal)
        {
            string data = "";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("AssesmentList", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@Groupid", SqlDbType.Int);
            parameter1.Value = assesmentDataModal.Group_Id;
            command.Parameters.Add(parameter1);

            SqlDataReader sqlDataReader =command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    assesmentDataModal.Assesment_Id = Convert.ToInt32(sqlDataReader[0]);
                    assesmentDataModal.Title = sqlDataReader[3].ToString();
                    assesmentDataModal.AssignDate = Convert.ToDateTime(sqlDataReader[4]);
                    data += " <a class='Panel_a' style=' text-decoration:none;' href='Assesment.aspx?Assesment_Id=" + assesmentDataModal.Assesment_Id + "'><div class='Panel'><h4> " + assesmentDataModal.Title + "</h4>" +
                       "<h6>" + assesmentDataModal.AssignDate + "<h6>" + "</div>";
                }
            }
            else
            {
                string msg1 = "No Data Found";
                data += " <a class='Panel_a' style=' text-decoration:none;' href='#'><div class='Panel'><h4  style='  text-align: center;' > " + msg1 + "</h4>"+ "</div>";
            }

            return data;
        } 
        public int CreateAssement(AssesmentDataModal assesmentDataModal)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                int AssesmentId = 0;
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("CreateAssement", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter("@Title", SqlDbType.VarChar);
                parameter1.Value = assesmentDataModal.Title;
                command.Parameters.Add(parameter1);

                SqlParameter parameter2 = new SqlParameter("@AssignDate", SqlDbType.VarChar);
                parameter2.Value = assesmentDataModal.AssignDate;
                command.Parameters.Add(parameter2);

                SqlParameter parameter3 = new SqlParameter("@Group_Id", SqlDbType.VarChar);
                parameter3.Value = assesmentDataModal.Group_Id;
                command.Parameters.Add(parameter3);

                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        AssesmentId = Convert.ToInt32(dataReader["AssementId"]);
                    }
                }
                return AssesmentId;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void AssementInfo(AssesmentInfoDataModal assesmentDataModal)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("AssementInfo", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter("@Assement_Id", SqlDbType.VarChar);
                parameter1.Value = assesmentDataModal.Assesment_Id;
                command.Parameters.Add(parameter1);

                SqlParameter parameter2 = new SqlParameter("@Question", SqlDbType.VarChar);
                parameter2.Value = assesmentDataModal.Question;
                command.Parameters.Add(parameter2);

                SqlParameter parameter3 = new SqlParameter("@Option1", SqlDbType.VarChar);
                parameter3.Value = assesmentDataModal.Option1;
                command.Parameters.Add(parameter3);

                SqlParameter parameter4 = new SqlParameter("@Option2", SqlDbType.VarChar);
                parameter4.Value = assesmentDataModal.Option2;
                command.Parameters.Add(parameter4);

                SqlParameter parameter5 = new SqlParameter("@Option3", SqlDbType.VarChar);
                parameter5.Value = assesmentDataModal.Option3;
                command.Parameters.Add(parameter5);

                SqlParameter parameter6 = new SqlParameter("@Option4", SqlDbType.VarChar);
                parameter6.Value = assesmentDataModal.Option4;
                command.Parameters.Add(parameter6);

                SqlParameter parameter7 = new SqlParameter("@CorrectOption", SqlDbType.VarChar);
                parameter7.Value = assesmentDataModal.CorrectOption;
                command.Parameters.Add(parameter7);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public ArrayList QuestionCounts(AssesmentDataModal assesmentDataModal)
        {
            try
            {
                int ID = 0;
                SqlConnection sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("QuestionCounts", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter("@ID", SqlDbType.VarChar);
               
                parameter1.Value = assesmentDataModal.Assesment_Id;
                command.Parameters.Add(parameter1);

                SqlDataReader sqlDataReader = command.ExecuteReader();
                ArrayList arrayList = new ArrayList();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        arrayList.Add(sqlDataReader[0]);
                       
                    }
                }
                return arrayList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<AssesmentInfoDataModal> FetchQuestion(AssesmentInfoDataModal assesmentInfoData)
        {
            List<AssesmentInfoDataModal> Question = new List<AssesmentInfoDataModal>();
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("FetchAssesment", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@GroupId", SqlDbType.Int);
            parameter1.Value = assesmentInfoData.GroupId;
            command.Parameters.Add(parameter1);

            SqlParameter parameter2 = new SqlParameter("@UserId", SqlDbType.Int);
            parameter2.Value = assesmentInfoData.TraineeId;
            command.Parameters.Add(parameter2);

            SqlParameter parameter3 = new SqlParameter("@Qno", SqlDbType.Int);
            parameter3.Value = assesmentInfoData.Id;
            command.Parameters.Add(parameter3);

            SqlParameter parameter4 = new SqlParameter("@AssesmentId", SqlDbType.Int);
            parameter4.Value = assesmentInfoData.Assesment_Id;
            command.Parameters.Add(parameter4);

            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    assesmentInfoData.Assesment_Id = Convert.ToInt32(sqlDataReader[0]);
                    assesmentInfoData.Question = sqlDataReader[1].ToString();
                    assesmentInfoData.Option1 = sqlDataReader[2].ToString();
                    assesmentInfoData.Option2 = sqlDataReader[3].ToString();
                    assesmentInfoData.Option3 = sqlDataReader[4].ToString();
                    assesmentInfoData.Option4 = sqlDataReader[5].ToString();
                    assesmentInfoData.CorrectOption = sqlDataReader[6].ToString();
                    Question.Add(assesmentInfoData);
                }
            }
            return Question;
        }

        public void MarkValidation(MarkValidationDataModal markValidationDataModal)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("MarkValidation", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter1 = new SqlParameter("@AssementId", SqlDbType.Int);
                parameter1.Value = markValidationDataModal.AssementId;
                command.Parameters.Add(parameter1);

                SqlParameter parameter2 = new SqlParameter("@QuestionId", SqlDbType.Int);
                parameter2.Value = markValidationDataModal.QuestionId;
                command.Parameters.Add(parameter2);

                SqlParameter parameter3 = new SqlParameter("@marks", SqlDbType.Int);
                parameter3.Value = markValidationDataModal.marks;
                command.Parameters.Add(parameter3);

                SqlParameter parameter4 = new SqlParameter("@traineeid", SqlDbType.Int);
                parameter4.Value = markValidationDataModal.trainee_id;
                command.Parameters.Add(parameter4);

                command.ExecuteNonQuery();
            }
            catch (Exception)
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
