using System;

namespace WebApplication2.Models
{
    public class DegreePlan
    {
        public int DegreePlanID { get; set; }
        public int StudentID { get; set; }
        public string DegreePlanAbbr { get; set; }
        public string DegreePlanName { get; set; }
        public int DegreePlanSelected { get; set; }


    }
}