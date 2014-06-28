using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalSystem.Models
{
    public class ExamineRecordList
    {
        public List<ExamineRecord> examineRecordList { set; get; }
        
        public ExamineRecordList()
        {
            examineRecordList = new List<ExamineRecord>();
        }
    }
}