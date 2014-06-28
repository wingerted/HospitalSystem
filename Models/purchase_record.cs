using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class purchase_record
    {
        public long PurchaseRecordID { get; set; }
        public Nullable<long> MedicineID { get; set; }
        public Nullable<long> StaffID { get; set; }
        public Nullable<int> MedicineNumber { get; set; }
        public Nullable<double> MedicinePrice { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public virtual medicine medicine { get; set; }
        public virtual staff staff { get; set; }
    }
}
