using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WCF_Exam.Entity;

namespace WCF_Exam.Data
{
    public class DBExamContext : DbContext
    {
        public DBExamContext() : base("name=EADExam")
        {
        }
        public DbSet<Employee> Employee { get; set; }
       
    }
}