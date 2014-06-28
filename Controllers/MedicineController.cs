using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using HospitalSystem.Models;

namespace HospitalSystem.Controllers
{
    public class MedicineController : Controller
    {
        public class MedicineNameAndAmount
        {
            public MedicineNameAndAmount(string name,int amount)
            {
                Name = name;
                Amount = amount;
            }
            public string Name {get;set; }
            public int Amount { get; set; }
        }

        private teamworkContext db = new teamworkContext();
        //
        // GET: /Medicine/
        [Authorize]
        public ActionResult Index()
        {
            MedicineNameAndAmount[] medicineNameAndAmount = { new MedicineNameAndAmount("null", 0) };
            ViewBag.MedicineNameAndAmount=medicineNameAndAmount;
            return View();
        }

        [HttpPost]
        public ActionResult Index(patient model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                string patientName = "";
                MedicineNameAndAmount[] medicineNameAndAmount = new MedicineNameAndAmount[1];
                try
                {
                    //patient patient = db.patients.Find(model.PatientID) .Find只能用于主键查询！！！
                    patient patient = db.patients.Find(model.PatientID);//为了取patientName
                    patientName = patient.Name;
                    
                    //病人ID（PatientId）--病历表medical_record-->最近的病历编号(MedicalRecordID)
                    List<medical_record> medical_recordlist = db.medical_record.Where(m => m.PatientID == model.PatientID).ToList();
                    medical_record medical_record = medical_recordlist[medical_recordlist.Count() - 1];
                    //病历编号(MedicalRecordID)--药方单表prescription-->药方编号(PrescriptionID)
                    List<prescription> prescriptionlist = db.prescriptions.Where(m => m.MedicalRecordID == medical_record.MedicalRecordID).ToList() ;
                    prescription prescription=prescriptionlist[prescriptionlist.Count()-1];
                    //药方编号(PrescriptionID)--药品详单表medicine_detail-->药品编号(MedicineID)、药品数量(MedicineNumber)（多个）
                    List<medicine_detail> medicinelist = db.medicine_detail.Where(m => m.PrescriptionID == prescription.PrescriptionID).ToList();
                    int medicineAmount=medicinelist.Count();//得到药品数
                    medicineNameAndAmount = new MedicineNameAndAmount[medicineAmount];
                    for (int i = 0; i < medicineAmount; i++)
                    {
                        //药品编号(MedicineID)--药品表medicine-->药品名(MedicineName)
                        medicine medicine = db.medicines.Find(medicinelist[i].MedicineID);
                        medicineNameAndAmount[i]=new MedicineNameAndAmount(medicine.MedicineName,Convert.ToInt32(medicinelist[i].MedicineNumber));
                    }
                }
                catch (Exception e)
                {
                    medicineNameAndAmount[0] = new MedicineNameAndAmount("null", 0);
                    patientName = "没有领药信息！";
                }
                finally
                {
                    ViewBag.MedicineNameAndAmount = medicineNameAndAmount;
                    ViewBag.PatientName = patientName;
                }
                return View();
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return View(model);
        }

    }
}
