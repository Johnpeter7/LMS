using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModal.Login
{
    public class UserDetailsList
    {
        public int Id { get; set; }
        public int Role_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }
        public string Mail_id { get; set; }
        public DateTime DOB { get; set; }
        public DateTime LastLogin { get; set; }
        public long Mobile_Number { get; set; }
    }
}
