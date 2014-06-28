using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class staff
    {
        public staff()
        {
            this.charge_record = new List<charge_record>();
            this.inbound_records = new List<inbound_records>();
            this.outbound_records = new List<outbound_records>();
            this.purchase_record = new List<purchase_record>();
            this.register_list = new List<register_list>();
            this.withdraw_medicine_record = new List<withdraw_medicine_record>();
            this.withdraw_registration_record = new List<withdraw_registration_record>();
        }

        public long StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffPassword { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Job { get; set; }
        public virtual ICollection<charge_record> charge_record { get; set; }
        public virtual ICollection<inbound_records> inbound_records { get; set; }
        public virtual ICollection<outbound_records> outbound_records { get; set; }
        public virtual ICollection<purchase_record> purchase_record { get; set; }
        public virtual ICollection<register_list> register_list { get; set; }
        public virtual ICollection<withdraw_medicine_record> withdraw_medicine_record { get; set; }
        public virtual ICollection<withdraw_registration_record> withdraw_registration_record { get; set; }
    }
}
