using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalSystem.Models;

namespace HospitalSystem.Business
{
    public class Examine
    {
        private teamworkContext db = new teamworkContext();

        public List<string> SearchExamine(string examineName) 
        {
            var examineSearch = db.examine_product.Where(m => m.ProductName.Contains(examineName));

            return examineSearch.Select(examine => examine.ProductName).ToList();
        }

        public examine_product GetExamineProductByName(string examineName)
        {
            return db.examine_product.FirstOrDefault(m => m.ProductName.Equals(examineName));
        }
    }
}