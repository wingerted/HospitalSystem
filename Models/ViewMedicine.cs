using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalSystem.Models
{
    public class ViewMedicine
    {
        public Nullable<long> MedicineID { get; set; }
        
        public string MedicineName { get; set; }
        
        public Nullable<int> MedicineCount { get; set; }
  
        public Nullable<double> MedicinePrice { get; set; }
    }
}