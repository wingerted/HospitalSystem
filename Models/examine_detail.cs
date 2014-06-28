using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class examine_detail
    {
        public long ExamineDetailID { get; set; }
        public Nullable<long> ExamineListID { get; set; }
        public Nullable<long> ProductID { get; set; }
        public Nullable<long> ExamineDoctorID { get; set; }
        public string ExamineResult { get; set; }
        public Nullable<System.DateTime> ExamineTime { get; set; }
        public virtual doctor doctor { get; set; }
        public virtual examine_list examine_list { get; set; }
        public virtual examine_product examine_product { get; set; }
    }
}
