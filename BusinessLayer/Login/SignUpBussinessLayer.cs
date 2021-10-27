using DataLayer.Login;
using DataModal.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModal.Login;

namespace BusinessLayer.Login
{
   public class SignUpBussinessLayer
    {
        public void SignUp(SignUpViewModal signUpViewModal)
        {
            SignUpDataModal signUpDataModal = new SignUpDataModal();
            signUpDataModal.First_Name = signUpViewModal.First_Name;
            signUpDataModal.Last_Name = signUpViewModal.Last_Name;
            signUpDataModal.Mobile_Number = signUpViewModal.Mobile_Number;
            signUpDataModal.Mail_id = signUpViewModal.Mail_id;
            signUpDataModal.DOB = signUpViewModal.DOB;
            signUpDataModal.Department = signUpViewModal.Department;
            SignUpDataLayer signUpDataLayer = new SignUpDataLayer();
            signUpDataLayer.SignUpData(signUpDataModal);
        }
        public List<SignUpViewModal> UserDetails(SignUpViewModal signUpViewModal)
        {
            List<SignUpDataModal> UserList = new List<SignUpDataModal>();
            SignUpDataLayer signUpDataLayer = new SignUpDataLayer();
            SignUpDataModal signUpDataModal = new SignUpDataModal();
            signUpDataModal.Id = signUpViewModal.Id;
            signUpDataModal.Role_Name = signUpViewModal.Role_Name;
            UserList = signUpDataLayer.GetUserDetails(signUpDataModal);
            List<SignUpViewModal> Users = new List<SignUpViewModal>();
            foreach (var userlist in UserList)
            {
                SignUpViewModal signUpViewModals = new SignUpViewModal();
                signUpViewModals.First_Name = userlist.First_Name;
                signUpViewModals.Mobile_Number = userlist.Mobile_Number;
                signUpViewModals.Last_Name = userlist.Last_Name;
                signUpViewModals.DOB = userlist.DOB;
                signUpViewModals.Mail_id = userlist.Mail_id;
                signUpViewModals.Password = userlist.Password;
                signUpViewModals.Department = userlist.Department;

                Users.Add(signUpViewModals);

            }

                return Users;
        }
    }
}
