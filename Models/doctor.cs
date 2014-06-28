using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Models
{
    public partial class doctor
    {
        public doctor()
        {
            this.adjust_price_record = new List<adjust_price_record>();
            this.allocate_record = new List<allocate_record>();
            this.appointment_record = new List<appointment_record>();
            this.approve_record = new List<approve_record>();
            this.approve_record1 = new List<approve_record>();
            this.examine_detail = new List<examine_detail>();
            this.medical_record = new List<medical_record>();
            this.register_list = new List<register_list>();
        }


        public long DoctorID { get; set; }
        public Nullable<long> DepartmentID { get; set; }
        public string DoctorPassword { get; set; }
        public string DoctorName { get; set; }
        public string DoctorGender { get; set; }
        public Nullable<bool> Expert { get; set; }
        public string Title { get; set; }
        public string Job { get; set; }
        public virtual ICollection<adjust_price_record> adjust_price_record { get; set; }
        public virtual ICollection<allocate_record> allocate_record { get; set; }
        public virtual ICollection<appointment_record> appointment_record { get; set; }
        public virtual ICollection<approve_record> approve_record { get; set; }
        public virtual ICollection<approve_record> approve_record1 { get; set; }
        public virtual department department { get; set; }
        public virtual ICollection<examine_detail> examine_detail { get; set; }
        public virtual ICollection<medical_record> medical_record { get; set; }
        public virtual ICollection<register_list> register_list { get; set; }
    }
}
