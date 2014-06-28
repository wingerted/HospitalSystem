using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class appointment_record
    {
        public long AppointmentID { get; set; }
        public Nullable<long> DoctorID { get; set; }
        public Nullable<long> PatientID { get; set; }
        public Nullable<System.DateTime> AppointmentTime { get; set; }
        public virtual doctor doctor { get; set; }
        public virtual patient patient { get; set; }
    }
}
