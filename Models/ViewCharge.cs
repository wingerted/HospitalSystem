using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSystem.Business;
using HospitalSystem.Models;
using System.ComponentModel.DataAnnotations;

namespace HospitalSystem.Models
{
    public class ViewCharge
    {
        public long ExamineDetailID { get; set; }
        public Nullable<long> ExamineListID { get; set; }
        public Nullable<long> ExamineDoctorID { get; set; }
        public Nullable<long> PrescriptionID { get; set; }
        public long PatientID { get; set; }
        [Required]
        [Display(Name = "姓名")]
        public string PatientName { get; set; }
        public List<ViewExamine> Examinelist{get;set;}
        public List<ViewMedicine> Medicinelist { get; set; }
        [Required]
        [Display(Name = "请付款：")]
        public double? totalPay { get; set; }
        public double? CollectPay { get; set; }
        public double? change{ get; set; }
        public ViewCharge() {
            this.Examinelist=new  List<ViewExamine>();
            this.Medicinelist = new List<ViewMedicine>();
        }


    }

}