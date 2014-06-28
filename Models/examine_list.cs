using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class examine_list
    {
        public examine_list()
        {
            this.charge_record = new List<charge_record>();
            this.examine_detail = new List<examine_detail>();
        }

        public long ExamineListID { get; set; }
        public Nullable<long> MedicalRecordID { get; set; }
        public virtual ICollection<charge_record> charge_record { get; set; }
        public virtual ICollection<examine_detail> examine_detail { get; set; }
        public virtual medical_record medical_record { get; set; }
    }
}
