///////////////////////////////////////////////////////////
//  Collector.cs
//  Implementation of the Class Collector
//  Generated by Enterprise Architect
//  Created on:      24-6��-2013 23:03:16
//  Original author: Winger
///////////////////////////////////////////////////////////

using System;
using HospitalSystem.Models;
using System.Data;
using System.Linq;

namespace HospitalSystem.Business
{
    public class Collector {
        teamworkContext db = new teamworkContext();
        public patient Patient { get; set; }

        public RegisterInformation registerInformation;
        public static NurseStation NurseStation = new NurseStation();
        /// <summary>
        /// ���벡��Id��[����ѡ�1�������Һţ�2�����Һż��½�������3���������շѣ��Ѿ��ֿ����ˣ��ʲ���Ҫoptionѡ��]���������ݿ⣬ �õ�ҩƷ�۸񣬼��㲢��д������Ϣ�࣬
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="option"></param>
        /// ���ؿ�����Ϣ����ҳ����ʾ
        public ViewCharge Charge(long patientId, long stuffId)
        {
            ViewCharge viewCharge = new ViewCharge();
            double tempTotalPay = 0;
            if (db.medical_record.Where(m => m.PatientID == patientId).ToList().Count == 0)
                return viewCharge;
            medical_record medicalRecordModel = db.medical_record.Where(m => m.PatientID == patientId).OrderByDescending(m => m.TreatTime).First();
            

            if (db.examine_list.Where(m => m.MedicalRecordID == medicalRecordModel.MedicalRecordID).ToList().Count != 0)
            {

                var examineList = (from xx in db.examine_product
                                   join id in medicalRecordModel
                                       .examine_list.First()
                                       .examine_detail
                                       .Select(m => m.ProductID)
                                   on xx.ProductID equals id.Value
                                   select new ViewExamine
                                   {
                                       ExamineID = xx.ProductID,
                                       ExamineName = xx.ProductName,
                                       ExaminePrice = xx.ProductPrice
                                   }).ToList();
                viewCharge.Examinelist = examineList;
                tempTotalPay += (double)examineList.Sum(m => m.ExaminePrice);
            }
            if (db.prescriptions.Where(m => m.MedicalRecordID == medicalRecordModel.MedicalRecordID).ToList().Count != 0)
            {
                var medicineList = (from id in medicalRecordModel
                                        .prescriptions.First()
                                        .medicine_detail.ToList()
                                    join xx in db.medicines
                                    on id.MedicineID equals xx.MedicineID
                                    select new ViewMedicine
                                    {
                                        MedicineID = xx.MedicineID,
                                        MedicineName = xx.MedicineName,
                                        MedicinePrice = xx.MedicinePrice,
                                        MedicineCount = id.MedicineNumber
                                    }).ToList();
                viewCharge.Medicinelist = medicineList;
                tempTotalPay += (double)medicineList.Sum(m => m.MedicinePrice * m.MedicineCount);
            }
            viewCharge.PatientID = patientId;

            viewCharge.PatientName = db.patients.Find(patientId).Name;

            viewCharge.totalPay = tempTotalPay;
            return viewCharge;
        }

        /// <summary>
        /// ����RegisterQueue�е�AddTotalQueueNumber,GetTotalQueueNumber, �õ���ǰ�����
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="department"></param>
        public long GenerateQueueNumber(long departmentNumber)
        {
            
            NurseStation.AddTotalQueueNumber(departmentNumber);
            return NurseStation.GetTotalQueueNumber(departmentNumber);
        }

        /// <summary>
        /// ��ȡ����Id��,
        /// �������ݿ⣬��д�Һ���Ϣ���е�����������Id������
        /// 
        /// ����GenerateQueueNumber�������õ�����ţ�����Һ���Ϣ����
        /// 
        /// ����Charge������1�������Һţ�2�����Һż��½�������3���������շѣ����õ�������Ϣ������Һ���Ϣ����
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="department"></param>
        /// �������˸Ķ�����staffIDҪ�����ݿ�
        public RegisterInformation RegisterHospital(long patientId, long departmentId, long stuffId)
        {
            registerInformation = new RegisterInformation();
            registerInformation.PatientId = patientId;
          
            patient patient = db.patients.Find(patientId);
            registerInformation.PatientName = patient.Name;
            
            department department = db.departments.Find(departmentId);
            registerInformation.DepartmentName = department.DepartmentName;
            
            registerInformation.QueueNumber = GenerateQueueNumber(departmentId);
            
            registerInformation.RegisterMoney = 8.00;
            
            /////////���������ӵ�registelist����ȥ�������ݿ�
            register_list registerList = new register_list();
            registerList.PatientID = patientId;
            registerList.DepartmentID = departmentId;
            registerList.RegisterTime = System.DateTime.Now;
            registerList.StaffID = stuffId;
            db.register_list.Add(registerList);
            
            db.SaveChanges();
            
            return registerInformation;
        }

        /// <summary>
        /// �����������������¡� �Ա� ��ϵ��ʽ���������ݿ�
        /// 
        /// �õ�����ID����������������Һ���Ϣ����
        /// 
        /// ����GenerateQueueNumber�������õ�����ţ�����Һ���Ϣ����
        /// 
        /// ����Charge������1�������Һţ�2�����Һż��½�������3���������շѣ����õ�������Ϣ������Һ���Ϣ����
        /// </summary>
        /// <param name="patientName"></param>
        /// <param name="birthDate"></param>
        /// <param name="gender"></param>
        /// <param name="tel"></param>
        /// <param name="department"></param>
        public long RegisterHospital(patient patientModel)
        {
            //��patientid, patientName ��birthDate��gender��telephone �������ݿ�

            //department department = db.departments.Find(departmentId);
            //registerInformation = new RegisterInformation();
            //registerInformation.DepartmentName = department.DepartmentName;
            //registerInformation.PatientId = patientModel.PatientID;
            //registerInformation.PatientName = patientModel.Name;
            //registerInformation.QueueNumber = GenerateQueueNumber(departmentId);
            //registerInformation.RegisterMoney = 9.50;

            ///////////���������ӵ�registelist����ȥ�������ݿ�
            //register_list registerList = new register_list();
            //registerList.PatientID = registerInformation.PatientId;
            //registerList.DepartmentID = departmentId;
            //registerList.RegisterTime = DateTime.Now;
            //registerList.StaffID = stuffId;

            //db.register_list.Add(registerList);
            db.patients.Add(patientModel);
            db.SaveChanges();

            return patientModel.PatientID;
        }


        public void SaveChargeRecord(long patientId, long stuffId, double sumPay)
        {
            charge_record chargeRecord = new charge_record();

            medical_record medicalRecord = db.medical_record.Where(m => m.PatientID == patientId).OrderByDescending(m => m.TreatTime).First();

      
            //chargeRecord.ExamineListID = medicalRecord.examine_list.First().ExamineListID;
            if (medicalRecord.examine_list.Count != 0)
            {
                chargeRecord.examine_list = medicalRecord.examine_list.First();
            }
            
            
                 
            //chargeRecord.PrescriptionID = medicalRecord.prescriptions.First().PrescriptionID;
            if (medicalRecord.prescriptions.Count != 0)
            {
                chargeRecord.prescription = medicalRecord.prescriptions.First();
            }
            


            chargeRecord.PatientID = patientId;
            chargeRecord.StaffID = stuffId;
            chargeRecord.SumPay = sumPay;
            chargeRecord.ChargeDate = DateTime.Now;
            
            db.charge_record.Add(chargeRecord);
            db.SaveChanges();
        }



    }
}//end Collector