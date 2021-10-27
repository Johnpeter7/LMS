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
  public  class LoginBusinessLayer
    {
        public List<LoginViewModal> UserLogin(LoginViewModal loginViewModal)
        {
            List<LoginDataModal> UserList = new List<LoginDataModal>();
            LoginDataLayer loginDataLayer = new LoginDataLayer();
            
            LoginDataModal loginDataModal = new LoginDataModal();
            loginDataModal.Mail_id = loginViewModal.Mail_id;
            loginDataModal.Password = loginViewModal.Password;
            UserList = loginDataLayer.ValidateUser(loginDataModal);
            List<LoginViewModal> Users = new List<LoginViewModal>();
            foreach (var userlist in UserList)
            {
                LoginViewModal loginViewModals = new LoginViewModal();
                loginViewModals.Id = userlist.Id;
                loginViewModals.Role_Name = userlist.Role_Name;
                Users.Add(loginViewModals);
            }


            return Users;
        }
        //public string UserLogin()
        //{
        //    string data = "";
        //    LoginViewModal loginViewModal=new LoginViewModal();
        //    LoginDataModal loginDataModal = new LoginDataModal();
        //    loginDataModal.Mail_id = loginViewModal.Mail_id;
        //    loginDataModal.Password = loginViewModal.Password;
        //    LoginDataLayer loginDataLayer = new LoginDataLayer();
        //    data= loginDataLayer.ValidateUser(loginDataModal);
        //    return data;
        //}
    }
}
