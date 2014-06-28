using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalSystem.Models;

namespace HospitalSystem.Business
{
    public class Department
    {
        private teamworkContext db = new teamworkContext();

        public IQueryable<department> GetDepartmentList()
        {
            return db.departments.Where(m => m.DepartmentType.Equals("检验科室") == false);
        }
    }
}