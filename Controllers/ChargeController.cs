using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSystem.Business;
using HospitalSystem.Models;

namespace HospitalSystem.Controllers
{
    public class ChargeController : Controller
    {
        private ViewCharge viewCharge = new ViewCharge();
        private Collector collecter = new Collector();
        private static long patientId;
        [Authorize]
        public ActionResult Index()
        {
            return View(viewCharge);
        }

        [HttpPost]
        public ActionResult Index(ViewCharge model)
        {
            patientId = model.PatientID;

            viewCharge = collecter.Charge(model.PatientID, long.Parse(Session["StaffID"].ToString()));

            return View(viewCharge);
        }


        [HttpPost]
        public ActionResult Charge(ViewCharge model)
        {
            collecter.SaveChargeRecord(patientId, long.Parse(Session["StaffID"].ToString()), (double)model.totalPay);

            return Json(viewCharge);
        }

        public ActionResult ShowShouldPayMoney()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShowShouldPayMoney(ViewCharge model)
        {
            ViewBag.cviewmodel = model;
            return Json(ViewBag.cviewmodel);
        }

    }
}
