using System;
using System.Collections.Generic;

namespace HospitalSystem.Models
{
    public partial class examine_product
    {
        public examine_product()
        {
            this.examine_detail = new List<examine_detail>();
        }

        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescribe { get; set; }
        public Nullable<double> ProductPrice { get; set; }
        public virtual ICollection<examine_detail> examine_detail { get; set; }
    }
}
