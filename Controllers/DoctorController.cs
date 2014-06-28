using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using HospitalSystem.Business;
using HospitalSystem.Models;

namespace HospitalSystem.Controllers
{
    public class AjaxData
    {
        public string matchInfo { get; set; }

        public long matchCount { get; set; }
    }

    public class DoctorController : Controller
    {
        //
        // GET: /CallNumber/
        private static Doctor doctor = new Doctor();
        private Examine examine = new Examine();
        private Medicine medicine = new Medicine();
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PatientSearch(long patientId)
        {
            return PartialView(doctor.GetCurrentPatient(patientId));   
        }

        [HttpPost]
        public ActionResult MedicineSearch(AjaxData xx)
        {
            return Json(medicine.SearchMedicine(xx.matchInfo));
        }

        [HttpPost]
        public ActionResult ExamineSearch(AjaxData xx)
        {
            return Json(examine.SearchExamine(xx.matchInfo));
        }

        [HttpPost]
        public ActionResult AddMessage(MedicalInformation medicalInformation)
        {
            
            doctor.AddDiagnosticMessage((long)Session["DoctorID"], medicalInformation);
           
            return View("Index");
        }

        [HttpPost]
        public ActionResult AddMedicine(string medicineName)
        {
            return PartialView(medicine.GetMedicineByName(medicineName));
        }

        [HttpPost]
        public ActionResult AddExamine(string examineName)
        {
            return PartialView(examine.GetExamineProductByName(examineName));
        }
    }
}