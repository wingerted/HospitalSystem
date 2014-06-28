using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class medicine_detail
    {
        public long MedicineDetailID { get; set; }
        public Nullable<long> MedicineID { get; set; }
        public Nullable<long> PrescriptionID { get; set; }
        public Nullable<int> MedicineNumber { get; set; }
        public virtual medicine medicine { get; set; }
        public virtual prescription prescription { get; set; }
    }
}
