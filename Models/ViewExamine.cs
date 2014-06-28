using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalSystem.Models
{
    public class ViewExamine
    {
        public Nullable<long> ExamineID { get; set; }
        
        public string ExamineName { get; set; }
        
        public Nullable<double> ExaminePrice { get; set; }
    }
}