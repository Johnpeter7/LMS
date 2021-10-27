using DataModal.Group;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Group
{
    public class GroupDataLayer
    {
        string connString = @"server=localhost;database=LMS;Integrated Security=True;";
        public int CreateGroup(GroupDataModal groupDataModal)
        {
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GroupCreation", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@Title", SqlDbType.VarChar);
            parameter1.Value = groupDataModal.Title;
            command.Parameters.Add(parameter1);

            SqlParameter parameter2 = new SqlParameter("@Description", SqlDbType.VarChar);
            parameter2.Value = groupDataModal.Description;
            command.Parameters.Add(parameter2);

            SqlParameter parameter3 = new SqlParameter("@Trainer_Id", SqlDbType.Int);
            parameter3.Value = groupDataModal.Trainer_Id;
            command.Parameters.Add(parameter3);

            //command.ExecuteNonQuery();
            SqlDataReader reader = command.ExecuteReader();
            int data =0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    groupDataModal.Group_Id = Convert.ToInt32(reader["GroupId"]);
                    data = groupDataModal.Group_Id;
                }
            }
            
            //sqlConnection.Close();
            return data;


        }
        public string GetGroupList(GroupDataModal groupDataModal)
        {
            string data = "";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("FetchGroupList", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@Trainer_ID", SqlDbType.Int);
            parameter1.Value = groupDataModal.Trainer_Id;
            command.Parameters.Add(parameter1);

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    groupDataModal.Group_Id = Convert.ToInt32(dataReader[0]);
                    groupDataModal.Title = Convert.ToString(dataReader[1]);
                    groupDataModal.Description = Convert.ToString(dataReader[3]);
                    
                    data += " <a class='Panel_a' style=' text-decoration:none;' href='GroupDashBoard.aspx?GroupId=" + groupDataModal.Group_Id+"'><div class='Panel'><h4 > " + groupDataModal.Title + "</h4>" + 
                        "<h6>" + groupDataModal.Description + "<h6>" + "</div>";
                }
            }


                return data;
        }

        public List<GroupDataModal> GetGroupInfo(GroupDataModal groupDataModal)
        {
            List<GroupDataModal> GroupInfo = new List<GroupDataModal>();
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetGroupInfo", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@GroupId", SqlDbType.Int);
            parameter1.Value = groupDataModal.Group_Id;
            command.Parameters.Add(parameter1);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    groupDataModal.Title = Convert.ToString(dataReader[1]);
                    groupDataModal.date = Convert.ToDateTime(dataReader[4]);
                    groupDataModal.Description = Convert.ToString(dataReader[3]);
                    GroupInfo.Add(groupDataModal);
                }
            }
            sqlConnection.Close();
            return GroupInfo;
        }

        public string GetTraineeGroupList(GroupDataModal groupDataModal)
        {
            string data = "";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("TraineeGroups", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@TraineeId", SqlDbType.Int);
            parameter1.Value = groupDataModal.Trainee_id;
            command.Parameters.Add(parameter1);

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    groupDataModal.Group_Id = Convert.ToInt32(dataReader[0]);
                    groupDataModal.Title = Convert.ToString(dataReader[1]);
                    groupDataModal.Description = Convert.ToString(dataReader[2]);

                    data += " <a class='Panel_a' style=' text-decoration:none;' href='TraineeGroups.aspx?GroupId=" + groupDataModal.Group_Id + "'><div class='Panel'><h4> " + groupDataModal.Title + "</h4>" +
                        "<h6>" + groupDataModal.Description + "<h6>" + "</div>";
                }
            }


            return data;
        }
    }
}
