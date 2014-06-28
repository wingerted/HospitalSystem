///////////////////////////////////////////////////////////
//  MedicineList.cs
//  Implementation of the Class MedicineList
//  Generated by Enterprise Architect
//  Created on:      25-6��-2013 14:19:18
//  Original author: Winger
///////////////////////////////////////////////////////////


using System.Collections.Generic;

namespace HospitalSystem.Business
{
    public class MedicineList {

        public double SumPay { get; set; }
        private List<MedicineRecord> medicineList;

        public MedicineList()
        {
            medicineList = new List<MedicineRecord>();
        }
    
        /// <summary>
        /// ����ҩƷ�ܼ�
        /// </summary>
        public void CountSumPay()
        {
            SumPay = 0;

            foreach (var medicineRecord in medicineList)
            {
                SumPay += medicineRecord.Price*medicineRecord.Number;
            }
        }

        /// <summary>
        /// ����ҩƷ��¼
        /// </summary>
        public void AddMedicineRecord(MedicineRecord medicineRecord)
        {
            medicineList.Add(medicineRecord);
        }

    }
}//end MedicineList