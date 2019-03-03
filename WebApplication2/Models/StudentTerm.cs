using System;

namespace WebApplication2.Models
{
    public class StudentTerm
    {
        public int StudentTermID { get; set; }
        public int StudentId { get; set; }
        public int Term { get; set; }
        public string TermAbbr { get; set; }
        public string TermName { get; set; }
       
    }
}