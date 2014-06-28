using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class patient
    {
        public patient()
        {
            this.appointment_record = new List<appointment_record>();
            this.charge_record = new List<charge_record>();
            this.medical_record = new List<medical_record>();
            this.register_list = new List<register_list>();
            this.withdraw_medicine_record = new List<withdraw_medicine_record>();
            this.withdraw_registration_record = new List<withdraw_registration_record>();
        }

        public long PatientID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Gender { get; set; }
        public string Telephone { get; set; }
        public virtual ICollection<appointment_record> appointment_record { get; set; }
        public virtual ICollection<charge_record> charge_record { get; set; }
        public virtual ICollection<medical_record> medical_record { get; set; }
        public virtual ICollection<register_list> register_list { get; set; }
        public virtual ICollection<withdraw_medicine_record> withdraw_medicine_record { get; set; }
        public virtual ICollection<withdraw_registration_record> withdraw_registration_record { get; set; }
    }
}
