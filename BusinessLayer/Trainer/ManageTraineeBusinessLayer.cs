using DataLayer.Trainer;
using DataModal.Login;
using DataModal.Trainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModal.Login;
using ViewModal.Trainer;namespace BusinessLayer.Trainer
{
    public class ManageTraineeBusinessLayer
    {
        public void AddTrainee(ManageTraineeViewModal manageTraineeViewModal)
        {
            ManageTraineeDataModal mangeTraineeDataModal = new ManageTraineeDataModal();
            mangeTraineeDataModal.First_Name = manageTraineeViewModal.First_Name;
            mangeTraineeDataModal.Last_Name = manageTraineeViewModal.Last_Name;
            mangeTraineeDataModal.Mobile_Number = manageTraineeViewModal.Mobile_Number;
            mangeTraineeDataModal.Email = manageTraineeViewModal.Email;
            mangeTraineeDataModal.DOB = manageTraineeViewModal.DOB;
            mangeTraineeDataModal.Group_id = manageTraineeViewModal.Group_id;
            ManageTraineeDataLayer manageTraineeDataLayer = new ManageTraineeDataLayer();
            manageTraineeDataLayer.AddTraineeData(mangeTraineeDataModal);
        }
        public void UpdateTrainer(SignUpViewModal signUpViewModal)
        {
            SignUpDataModal signUpDataModal = new SignUpDataModal();
            signUpDataModal.Department = signUpViewModal.Department;
            signUpDataModal.First_Name = signUpViewModal.First_Name;
            signUpDataModal.Last_Name = signUpViewModal.Last_Name;
            signUpDataModal.Mobile_Number = signUpViewModal.Mobile_Number;
            signUpDataModal.DOB = signUpViewModal.DOB;
            signUpDataModal.Password = signUpViewModal.Password;
            signUpDataModal.Mail_id = signUpViewModal.Mail_id;
            signUpDataModal.Id = signUpViewModal.Id;
            signUpDataModal.Role_Name = signUpViewModal.Role_Name;
            ManageTraineeDataLayer manageTraineeDataLayer = new ManageTraineeDataLayer();
            manageTraineeDataLayer.UpdateProfile(signUpDataModal);
        }
        public List<SignUpViewModal> GetTraineeDetails()
        {
            List<SignUpDataModal> TraineeData = new List<SignUpDataModal>();
            ManageTraineeDataLayer manageTraineeDataLayer = new ManageTraineeDataLayer();
            TraineeData = manageTraineeDataLayer.GetTraineeDetails(); List<SignUpViewModal> Trainees = new List<SignUpViewModal>();
            foreach (var userlist in TraineeData)
            {
                SignUpViewModal signUpViewModals = new SignUpViewModal();
                signUpViewModals.First_Name = userlist.First_Name;
                signUpViewModals.Mobile_Number = userlist.Mobile_Number;
                signUpViewModals.Last_Name = userlist.Last_Name;
                signUpViewModals.DOB = userlist.DOB;
                signUpViewModals.Mail_id = userlist.Mail_id;
                signUpViewModals.Password = userlist.Password;
                signUpViewModals.Department = userlist.Department;
                signUpViewModals.LastLogin = userlist.LastLogin;
                Trainees.Add(signUpViewModals);
            }
            return Trainees;
        }
    }
}

