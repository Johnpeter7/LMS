using DataLayer.Group;
using DataModal.Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModal.Group;

namespace BusinessLayer.Group
{
  public  class GroupBussinessLayer
    {
        public int GroupCreation(GroupViewModal groupViewModal)
        {
            int data = 0;
            GroupDataModal groupDataModal = new GroupDataModal();
            groupDataModal.Title = groupViewModal.Title;
            groupDataModal.Trainer_Id = groupViewModal.Trainer_Id;
            groupDataModal.Description = groupViewModal.Description;
            GroupDataLayer groupDataLayer = new GroupDataLayer();
            data= groupDataLayer.CreateGroup(groupDataModal);
            return data;
        }
        public string GroupList(GroupViewModal groupViewModal)
        {
            string data = "";
            GroupDataLayer groupDataLayer = new GroupDataLayer();
            GroupDataModal groupDataModal = new GroupDataModal();
            groupDataModal.Trainer_Id = groupViewModal.Trainer_Id;
            data = groupDataLayer.GetGroupList(groupDataModal);
            return data;
        }
        public string TraineeGroupList(GroupViewModal groupViewModal)
        {
            string data = "";
            GroupDataLayer groupDataLayer = new GroupDataLayer();
            GroupDataModal groupDataModal = new GroupDataModal();
            groupDataModal.Trainee_id = groupViewModal.Trainee_Id;
            data = groupDataLayer.GetTraineeGroupList(groupDataModal);
            return data;
        }
        public List<GroupViewModal> GroupInfo(GroupViewModal groupViewModal)
        {
            List<GroupDataModal> GroupInfo = new List<GroupDataModal>();
            GroupDataLayer groupDataLayer = new GroupDataLayer();
            GroupDataModal groupDataModal = new GroupDataModal();
            groupDataModal.Group_Id = groupViewModal.Group_Id;
            GroupInfo = groupDataLayer.GetGroupInfo(groupDataModal);
            List<GroupViewModal> InfoGroup = new List<GroupViewModal>();
            foreach (var item in GroupInfo)
            {
               
                groupViewModal.Title = item.Title;
                groupViewModal.Description = item.Description;
                groupViewModal.date = item.date;
                InfoGroup.Add(groupViewModal);
            }
          
            return InfoGroup;
        }
    }
}
