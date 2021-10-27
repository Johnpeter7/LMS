using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModal.Group
{
    public class GroupInfoView
    {
        public int Group_Id { get; set; }
        public string Title { get; set; }
        public int Trainer_Id { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public string status { get; set; }
    }
}
