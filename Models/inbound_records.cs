using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class inbound_records
    {
        public long InboundRecordsID { get; set; }
        public Nullable<long> MedicineID { get; set; }
        public Nullable<long> StaffID { get; set; }
        public Nullable<int> MedicineNumber { get; set; }
        public Nullable<System.DateTime> ManufactureDate { get; set; }
        public Nullable<System.DateTime> InboundDate { get; set; }
        public virtual medicine medicine { get; set; }
        public virtual staff staff { get; set; }
    }
}
