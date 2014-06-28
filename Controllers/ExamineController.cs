using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSystem.Business;
using HospitalSystem.Models;

namespace HospitalSystem.Controllers
{
    public class ExamineController : Controller
    {
        private static Doctor doctor = new Doctor();
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetExamineRecordList(long patientId)
        {
            if ((ViewBag.currentPatient = doctor.GetCurrentPatient(patientId)) == null)
            {
                return HttpNotFound();
            }

            var examineList = doctor.GetExamineRecordList(patientId);
            
            return View("Index", examineList);
        }


        public ActionResult AddExamineResult(List<ExamineRecord> examineRecordList)
        {
            if (ModelState.IsValid)
            {
                doctor.AddExamineResult(examineRecordList, long.Parse(Session["DoctorID"].ToString()));
            }
            
            return View("Index");
        }

    }
}
