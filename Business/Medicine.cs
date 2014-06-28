using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalSystem.Models;

namespace HospitalSystem.Business
{
    public class Medicine
    {
        private teamworkContext db = new teamworkContext();

        public List<string> SearchMedicine(string medicineName)
        {
            var medicineSearch = db.medicines.Where(m => m.MedicineName.Contains(medicineName));

            return medicineSearch.Select(medicine => medicine.MedicineName).ToList();
        }

        public medicine GetMedicineByName(string medicineName)
        {
            return db.medicines.FirstOrDefault(m => m.MedicineName.Equals(medicineName));
        }
    }
}