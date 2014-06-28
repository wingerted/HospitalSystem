using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class medicine
    {
        public medicine()
        {
            this.adjust_price_record = new List<adjust_price_record>();
            this.allocate_record = new List<allocate_record>();
            this.approve_record = new List<approve_record>();
            this.inbound_records = new List<inbound_records>();
            this.medicine_detail = new List<medicine_detail>();
            this.medicine_inventory = new List<medicine_inventory>();
            this.outbound_records = new List<outbound_records>();
            this.purchase_record = new List<purchase_record>();
            this.withdraw_medicine_record = new List<withdraw_medicine_record>();
        }

        public long MedicineID { get; set; }
        public string MedicineName { get; set; }
        public Nullable<double> MedicinePrice { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public string PackageCompany { get; set; }
        public string DispensingCompany { get; set; }
        public Nullable<bool> Poison { get; set; }
        public Nullable<bool> Psychotic { get; set; }
        public Nullable<bool> Precious { get; set; }
        public Nullable<bool> MakeSelf { get; set; }
        public Nullable<bool> Entrance { get; set; }
        public Nullable<bool> PaySelf { get; set; }
        public Nullable<System.DateTime> ValidityDate { get; set; }
        public Nullable<int> MaxNumber { get; set; }
        public virtual ICollection<adjust_price_record> adjust_price_record { get; set; }
        public virtual ICollection<allocate_record> allocate_record { get; set; }
        public virtual ICollection<approve_record> approve_record { get; set; }
        public virtual ICollection<inbound_records> inbound_records { get; set; }
        public virtual ICollection<medicine_detail> medicine_detail { get; set; }
        public virtual ICollection<medicine_inventory> medicine_inventory { get; set; }
        public virtual ICollection<outbound_records> outbound_records { get; set; }
        public virtual ICollection<purchase_record> purchase_record { get; set; }
        public virtual ICollection<withdraw_medicine_record> withdraw_medicine_record { get; set; }
    }
}
