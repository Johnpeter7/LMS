﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModal.Assement
{
    public class QuestionList
    {
        public int Id { get; set; }
        public int TraineeId { get; set; }
        public int GroupId { get; set; }
        public int Assesment_Id { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectOption { get; set; }
    }
}