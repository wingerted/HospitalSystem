using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalSystem.Models
{
    public class MedicalInformation
    {
        public long PatientId { get; set; }
        public string Diagnostic { get; set; }
        public List<ViewMedicine> MedicineRecord { get; set; }
        public List<ViewExamine> ExamRecord { get; set; }
    }
}