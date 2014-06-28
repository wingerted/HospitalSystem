using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class prescription
    {
        public prescription()
        {
            this.charge_record = new List<charge_record>();
            this.medicine_detail = new List<medicine_detail>();
        }

        public long PrescriptionID { get; set; }
        public Nullable<long> MedicalRecordID { get; set; }
        public virtual ICollection<charge_record> charge_record { get; set; }
        public virtual medical_record medical_record { get; set; }
        public virtual ICollection<medicine_detail> medicine_detail { get; set; }
    }
}
