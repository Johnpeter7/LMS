using DataLayer.Assesment;
using DataModal.Assesment;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModal.Assement;

namespace BusinessLayer.Assesment
{
   public  class AssesmentBusinessLayer
    {
        string connString = @"server=localhost;database=LMS;Integrated Security=True;";
        AssesmentDataLayer assesmentDataLayer = new AssesmentDataLayer();

        public string FetchResult(AssesmentResult assesmentResult)
        {
            string data = "";
            AssesmentResultDataModal assesmentResultDataModal = new AssesmentResultDataModal();
           
            assesmentResultDataModal.trainee_id = assesmentResult.trainee_id;
            AssesmentDataLayer assesmentDataLayer = new AssesmentDataLayer();
            data = assesmentDataLayer.FetchResult(assesmentResultDataModal);
            return data;
        }
        public List<AssesmentViewModal> FetchAssesmentData(AssesmentViewModal assesmentViewModal)
        {
            List<AssesmentDataModal> assesmentDataModals = new List<AssesmentDataModal>();
            AssesmentDataLayer assesmentDataLayer = new AssesmentDataLayer();
            AssesmentDataModal assesmentDataModal = new AssesmentDataModal();
            assesmentDataModal.Assesment_Id = assesmentViewModal.Assesment_Id;
            assesmentDataModals = assesmentDataLayer.FetchAssesmentData(assesmentDataModal);
            List<AssesmentViewModal> assesmentViewModals = new List<AssesmentViewModal>();
            foreach (var item in assesmentDataModals)
            {
                assesmentViewModal.Title = item.Title;
                assesmentViewModal.counts = item.counts;
                assesmentViewModals.Add(assesmentViewModal);
            }
            return assesmentViewModals;

        }
        public string AssesmentList(AssesmentViewModal assesmentViewModal)
        {
            string data = "";
            AssesmentBusinessLayer assesmentBusinessLayer = new AssesmentBusinessLayer();
            AssesmentDataModal assesmentDataModal = new AssesmentDataModal();
            assesmentDataModal.Group_Id = assesmentViewModal.Group_Id;
            data=assesmentDataLayer.AssesmentList(assesmentDataModal);
           
            return data;
        }
        public int CreateAssesment(AssesmentViewModal assesmentViewModal)
        {
            int AssesmentId = 0;
            AssesmentDataModal assesmentDataModal = new AssesmentDataModal();
            assesmentDataModal.AssignDate = assesmentViewModal.AssignDate;
            assesmentDataModal.Title = assesmentViewModal.Title;
            assesmentDataModal.Group_Id = assesmentViewModal.Group_Id;
           
            AssesmentId=assesmentDataLayer.CreateAssement(assesmentDataModal);
            return AssesmentId;
        }
        public void AssesmentInfo(AssesmentInfoViewModal assesmentInfoViewModal)
        {
            AssesmentInfoDataModal assesmentInfoDataModal = new AssesmentInfoDataModal();
            assesmentInfoDataModal.Assesment_Id = assesmentInfoViewModal.Assesment_Id;
            assesmentInfoDataModal.Question = assesmentInfoViewModal.Question;
            assesmentInfoDataModal.Option1 = assesmentInfoViewModal.Option1;
            assesmentInfoDataModal.Option2 = assesmentInfoViewModal.Option2;
            assesmentInfoDataModal.Option3 = assesmentInfoViewModal.Option3;
            assesmentInfoDataModal.Option4 = assesmentInfoViewModal.Option4;
            assesmentInfoDataModal.CorrectOption = assesmentInfoViewModal.CorrectOption;
            assesmentDataLayer.AssementInfo(assesmentInfoDataModal);
        }

        public ArrayList QuestionCounts(AssesmentViewModal assesmentViewModal)
        {
            //int ID = 0;
            ArrayList arrayList = new ArrayList();
            AssesmentDataLayer assesmentDataLayer = new AssesmentDataLayer();
            AssesmentDataModal assesmentDataModal = new AssesmentDataModal();
            
            assesmentDataModal.Assesment_Id= assesmentViewModal.Assesment_Id;
            arrayList = assesmentDataLayer.QuestionCounts(assesmentDataModal);
            return arrayList;
        }

        public List<AssesmentInfoViewModal> FetchQuestion(AssesmentInfoViewModal assesmentInfoViewModal)
        {
            List<AssesmentInfoDataModal> Question = new List<AssesmentInfoDataModal>();
            AssesmentDataLayer assesmentInfoDataLayer = new AssesmentDataLayer();
            AssesmentInfoDataModal assesmentInfoDataModal = new AssesmentInfoDataModal();
            assesmentInfoDataModal.GroupId = assesmentInfoViewModal.GroupId;
            assesmentInfoDataModal.TraineeId = assesmentInfoViewModal.TraineeId;
            assesmentInfoDataModal.Id = assesmentInfoViewModal.Id;
            assesmentInfoDataModal.Assesment_Id = assesmentInfoViewModal.Assesment_Id;
            Question=assesmentInfoDataLayer.FetchQuestion(assesmentInfoDataModal);
            List<AssesmentInfoViewModal> QuestionList = new List<AssesmentInfoViewModal>();
            foreach (var item in Question)
            {
                assesmentInfoViewModal.Assesment_Id = item.Assesment_Id;
                assesmentInfoViewModal.Question = item.Question;
                assesmentInfoViewModal.Option1 = item.Option1;
                assesmentInfoViewModal.Option2 = item.Option2;
                assesmentInfoViewModal.Option3 = item.Option3;
                assesmentInfoViewModal.Option4 = item.Option4;
                assesmentInfoViewModal.CorrectOption = item.CorrectOption;
                QuestionList.Add(assesmentInfoViewModal);

            }
            return QuestionList;
        }

        public void MarkValidation(MarkValidation markValidation)
        {
            AssesmentDataLayer assesmentDataLayer = new AssesmentDataLayer();
            MarkValidationDataModal markValidationDataModal = new MarkValidationDataModal();
            markValidationDataModal.AssementId = markValidation.AssementId;
            markValidationDataModal.QuestionId = markValidation.QuestionId;
            markValidationDataModal.marks = markValidation.marks;
            markValidationDataModal.trainee_id = markValidation.trainee_id;
            assesmentDataLayer.MarkValidation(markValidationDataModal);


        }
    }
}
