using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class withdraw_medicine_record
    {
        public long WithdrawMedicineRecordID { get; set; }
        public Nullable<long> MedicineID { get; set; }
        public Nullable<long> PatientID { get; set; }
        public Nullable<long> StaffID { get; set; }
        public Nullable<int> MedicineNumber { get; set; }
        public Nullable<System.DateTime> WithdrawMedicineDate { get; set; }
        public virtual medicine medicine { get; set; }
        public virtual patient patient { get; set; }
        public virtual staff staff { get; set; }
    }
}
