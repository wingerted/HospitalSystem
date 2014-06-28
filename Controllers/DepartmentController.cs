using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSystem.Models;

namespace HospitalSystem.Controllers
{ 
    public class DepartmentController : Controller
    {
        private teamworkContext db = new teamworkContext();

        //
        // GET: /Department/

        public ViewResult Index()
        {
            return View(db.departments.ToList());
        }

        //
        // GET: /Department/Details/5

        public ViewResult Details(long id)
        {
            department department = db.departments.Find(id);
            return View(department);
        }

        //
        // GET: /Department/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Department/Create

        [HttpPost]
        public ActionResult Create(department department)
        {
            if (ModelState.IsValid)
            {
                db.departments.Add(department);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(department);
        }
        
        //
        // GET: /Department/Edit/5
 
        public ActionResult Edit(long id)
        {
            department department = db.departments.Find(id);
            return View(department);
        }

        //
        // POST: /Department/Edit/5

        [HttpPost]
        public ActionResult Edit(department department)
        {
            if (ModelState.IsValid)
            {
                db.Entry(department).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        //
        // GET: /Department/Delete/5
 
        public ActionResult Delete(long id)
        {
            department department = db.departments.Find(id);
            return View(department);
        }

        //
        // POST: /Department/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {            
            department department = db.departments.Find(id);
            db.departments.Remove(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}