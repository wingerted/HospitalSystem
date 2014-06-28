using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class medicine_inventory
    {
        public long MedicineInventoryID { get; set; }
        public Nullable<long> MedicineID { get; set; }
        public Nullable<System.DateTime> ManufactureDate { get; set; }
        public Nullable<int> InventoryNumber { get; set; }
        public virtual medicine medicine { get; set; }
    }
}
