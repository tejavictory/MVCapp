using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class DegreePlan
    {
        [Key]
        public int DegreePlanID { get; set; }
        public int StudentID { get; set; }
        public string DegreePlanAbbr { get; set; }
        public string DegreePlanName { get; set; }
        public int DegreePlanSelected { get; set; }


    }
}