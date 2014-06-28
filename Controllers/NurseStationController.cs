using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSystem.Business;

namespace HospitalSystem.Controllers
{
    public class NurseStationController : Controller
    {
        static NurseStation nurseStation = new NurseStation();
        RegisterQueue[] registerQueue;
        //RegisterQueue[] registerQueue = { NurseStation.RegisterQueueArray[0], NurseStation.RegisterQueueArray[1], NurseStation.RegisterQueueArray[2]};
        //
        // GET: /NurseStation/
        [Authorize]
        public ActionResult Index()
        {
            registerQueue = new RegisterQueue[NurseStation.DepartmentAmount];
            for (int i = 0; i < NurseStation.DepartmentAmount; i++)
                registerQueue[i] = NurseStation.RegisterQueueArray[i];
            ViewBag.RegisterQueue = registerQueue;
            return View();
        }

        public ActionResult CallPatient(long departmentId)
        {
            nurseStation.CallPatient(departmentId);
            return RedirectToAction("Index");
        }

        public ActionResult CancelCallPatient(long departmentId)
        {
            nurseStation.CancelCallPatient(departmentId);
            return RedirectToAction("Index");
        }

        //public ActionResult Test()
        //{
        //    return View();
        //}

    }
}
