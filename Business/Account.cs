using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalSystem.Models;

namespace HospitalSystem.Business
{

    public class Account
    {

        private static readonly teamworkContext db = new teamworkContext();
        
        public doctor GetDoctor(long doctorID, string doctorPassword,string job)
        {
            return db.doctors.FirstOrDefault(d => d.DoctorID ==  doctorID && d.DoctorPassword == doctorPassword && d.Job==job);
        }

        public staff GetStaff(long staffID, string staffPassword, string job)
        {
            return db.staffs.FirstOrDefault(d => d.StaffID == staffID && d.StaffPassword == staffPassword && d.Job==job);
        }
    }
}