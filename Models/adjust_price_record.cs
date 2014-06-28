using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class adjust_price_record
    {
        public long AdjustPriceRecordID { get; set; }
        public Nullable<long> MedicineID { get; set; }
        public Nullable<long> DoctorID { get; set; }
        public Nullable<double> MedicineOldPrice { get; set; }
        public Nullable<double> MedicineCurrentPrice { get; set; }
        public Nullable<System.DateTime> AdjustPriceDate { get; set; }
        public virtual doctor doctor { get; set; }
        public virtual medicine medicine { get; set; }
    }
}
