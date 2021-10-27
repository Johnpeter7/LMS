using BusinessLayer.Assesment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewModal.Assement;

namespace LMS_Web.UI.Trainee
{
    public partial class Assesment : System.Web.UI.Page
    {
        ArrayList arrayList = new ArrayList();
        string connString = @"server=localhost;database=LMS;Integrated Security=True;";
       
       
        int count = 0;
        int counts = 0;
        
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

            string AssesmentId = Request.QueryString["Assesment_Id"];
            FetchAssesmentDetails(AssesmentId);

        }

        private void FetchAssesmentDetails(string assesmentId)
        {
            int total = 0;
            int count = 0;
            AssesmentBusinessLayer assesmentBusinessLayer = new AssesmentBusinessLayer();
            List<AssesmentViewModal> assesmentViewModals = new List<AssesmentViewModal>();
            AssesmentViewModal assesmentViewModal = new AssesmentViewModal();
            assesmentViewModal.Assesment_Id = Convert.ToInt32(assesmentId);
            assesmentViewModals = assesmentBusinessLayer.FetchAssesmentData(assesmentViewModal);
            AssesmentData assesmentData = new AssesmentData();
            List<AssesmentData> assesmentDatas = new List<AssesmentData>();
            foreach (var item in assesmentViewModals)
            {
                assesmentData.Title = item.Title;
                assesmentData.counts = item.counts;
                assesmentDatas.Add(assesmentData);


            }
            count = assesmentData.counts;
            total = count * 5;
            lblTitle.Text = assesmentData.Title;
            lblcounts.Text = count.ToString();
            lblMarks.Text = total.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Group_Id = Convert.ToInt32(Session["Group_Id"]);
            int user_id = Convert.ToInt32(Session["UserId"]);

            Session["SelectedOption"] = RadioButtonList1.SelectedItem.Text;
            int AssementId = Convert.ToInt32(Session["AssementId"]);
            int id =Convert.ToInt32( Session["qno"]);
            string CorrectOption = Session["CorrectOption"].ToString();
            string SelectedOption = Session["SelectedOption"].ToString();
            ValidationMark(AssementId, user_id, id, CorrectOption, SelectedOption);

            AssesmentBusinessLayer assementBusinessLayer = new AssesmentBusinessLayer();
            AssesmentViewModal assesmentViewModal = new AssesmentViewModal();
            string AssesmentId = Request.QueryString["Assesment_Id"];
            assesmentViewModal.Assesment_Id = Convert.ToInt32(AssesmentId);
            arrayList = assementBusinessLayer.QuestionCounts(assesmentViewModal);
            //arrayList.Add(GetCounts);
            int DataCount = arrayList.Count;
            counts = Convert.ToInt32(ViewState["qno"]);
            counts++;
            ViewState["qno"] = counts;
            counts = Convert.ToInt32(ViewState["qno"]);
            if (DataCount == counts+1)
            {
                lblQuestion.Text = "";
                RadioButtonList1.Items.Clear();
                int Qno = Convert.ToInt32(arrayList[counts]);
                Button1.Visible = false;
                btnComplete.Visible = true;
                FetchAssesment(Group_Id, user_id, Qno);
            }
            else
            {
                lblQuestion.Text = "";
                RadioButtonList1.Items.Clear();
                int Qno = Convert.ToInt32(arrayList[counts]);
                //SelectedOption = RadioButtonList1.SelectedItem.Text;
                FetchAssesment(Group_Id, user_id, Qno);
                

            }
            
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Group_Id = Convert.ToInt32(Session["Group_Id"]);
            int user_id = Convert.ToInt32(Session["UserId"]);
            string AssesmentId = Request.QueryString["Assesment_Id"];
            AssesmentBusinessLayer assementBusinessLayer = new AssesmentBusinessLayer();
            AssesmentViewModal assesmentViewModal = new AssesmentViewModal();
            assesmentViewModal.Assesment_Id = Convert.ToInt32(AssesmentId);
            
            arrayList = assementBusinessLayer.QuestionCounts(assesmentViewModal);

             int DataCount = arrayList.Count;
            int Qno = Convert.ToInt32(arrayList[count]);
            //SelectedOption = RadioButtonList1.SelectedItem.Text;
            FetchAssesment(Group_Id, user_id, Qno);
            //ValidationMark(AssementId, user_id, Qno, CorrectOption, SelectedOption);
            Panel1.Visible = true;
            Button2.Visible = false;
        }

        private void FetchAssesment(int group_Id, int user_id, int qno)
        {
            int Group_Id = Convert.ToInt32(Session["Group_Id"]);
            string AssesmentId = Request.QueryString["Assesment_Id"];
            //int user_id = Convert.ToInt32(Session["UserId"]);
            AssesmentBusinessLayer assesmentBusinessLayer = new AssesmentBusinessLayer();
            List<AssesmentInfoViewModal> assesmentInfoViewModals = new List<AssesmentInfoViewModal>();
            AssesmentInfoViewModal assesmentInfoViewModal = new AssesmentInfoViewModal();
            assesmentInfoViewModal.GroupId = group_Id;
            assesmentInfoViewModal.TraineeId = user_id;
            assesmentInfoViewModal.Id = qno;
            assesmentInfoViewModal.Assesment_Id =Convert.ToInt32( AssesmentId);
            Session["qno"] = assesmentInfoViewModal.Id;
            assesmentInfoViewModals = assesmentBusinessLayer.FetchQuestion(assesmentInfoViewModal);
            List<QuestionList> questionLists = new List<QuestionList>();
            QuestionList questionList = new QuestionList();
            foreach (var item in assesmentInfoViewModals)
            {
                questionList.Assesment_Id = item.Assesment_Id;
                questionList.Question = item.Question;
                questionList.Option1 = item.Option1;
                questionList.Option2 = item.Option2;
                questionList.Option3 = item.Option3;
                questionList.Option4 = item.Option4;
                questionList.CorrectOption = item.CorrectOption;
                questionLists.Add(questionList);

            }
            string CorrectOption = questionList.CorrectOption;
            Session["CorrectOption"] = CorrectOption;
            int AssementId = questionList.Assesment_Id;
            Session["AssementId"] = AssementId;
            lblQuestion.Text = questionList.Question;
            RadioButtonList1.Items.Add(questionList.Option1);
            RadioButtonList1.Items.Add(questionList.Option2);
            RadioButtonList1.Items.Add(questionList.Option3);
            RadioButtonList1.Items.Add(questionList.Option4);
            
           

        }

        private void ValidationMark(int assementId, int user_id, int id, string correctOption,string SelectedOption)
        {
            int mark = 0;
            MarkValidation markValidation = new MarkValidation();
            
            AssesmentBusinessLayer assesmentBusinessLayer = new AssesmentBusinessLayer();
            if (correctOption == SelectedOption)
            {
                mark = 5;
                markValidation.marks = mark;
                markValidation.trainee_id = user_id;
                markValidation.AssementId = assementId;
                markValidation.QuestionId = id;
                assesmentBusinessLayer.MarkValidation(markValidation);
            }
            else
            {
                mark = 0;
                markValidation.marks = mark;
                markValidation.trainee_id = user_id;
                markValidation.AssementId = assementId;
                markValidation.QuestionId = id;
                assesmentBusinessLayer.MarkValidation(markValidation);
            }
        }

        protected void btnComplete_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Session["UserId"]);
            Session["SelectedOption"] = RadioButtonList1.SelectedItem.Text;
            int AssementId = Convert.ToInt32(Session["AssementId"]);
            int id = Convert.ToInt32(Session["qno"]);
            string CorrectOption = Session["CorrectOption"].ToString();
            string SelectedOption = Session["SelectedOption"].ToString();
            ValidationMark(AssementId, user_id, id, CorrectOption, SelectedOption);
            Response.Redirect("../../Home.aspx");
        }
    }
}