using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class StudentTerm
    {
        [Key]
        public int StudentTermID { get; set; }
        public int StudentID { get; set; }
        public int Term { get; set; }
        public string TermAbbr { get; set; }
        public string TermName { get; set; }
       
    }
}