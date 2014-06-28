using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSystem.Models;
using HospitalSystem.Business;

namespace HospitalSystem.Controllers
{
    public class RegisterController : Controller
    {
        public Collector collecter = new Collector();
        public Department department = new Department();

        public ActionResult Index()
        {     
            ViewBag.departmentlist = department.GetDepartmentList();

            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterInformation model)
        {
            // if(isvalid)病人id存在读取数据库获取病人姓名
            if (ModelState.IsValid)
            {
                return Json(collecter.RegisterHospital(
                    model.PatientId, 
                    model.DepartmentID, 
                    long.Parse(Session["StaffID"].ToString()))
                );
            }

            return View();
        }

        public ActionResult RegisterAndCreate()
        {
            patient b = new patient();
            b.PatientID = 0;
            ViewBag.patient = b;
            return View();
        }

        [HttpPost]
        public ActionResult RegisterAndCreate(patient model, string returnUrl)
        {
            //ViewBag.register = collecter.RegisterHospital(model, 1, long.Parse(Session["StaffID"].ToString()));


            patient b = new patient();
            b.PatientID = collecter.RegisterHospital(model);
            ViewBag.patient = b;
            return Json(ViewBag.patient);
        }

        [HttpPost]
        public ActionResult ReturnToIndex(patient model)
        {
            //ViewBag.register = collecter.RegisterHospital(model, 1, long.Parse(Session["StaffID"].ToString()));

            RegisterInformation rinformation = new RegisterInformation();
            rinformation.PatientId = model.PatientID;
            rinformation.DepartmentID = 0;
            ViewBag.rinformation = rinformation;

            ViewBag.departmentlist = department.GetDepartmentList();
            return View("Index", rinformation);
        }

    }
}