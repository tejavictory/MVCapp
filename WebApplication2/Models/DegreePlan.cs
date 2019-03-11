using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class DegreePlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }
        public int StudentId { get; set; }
        public string DegreePlanAbbr { get; set; }
        public string DegreePlanName { get; set; }
        public int DegreePlanSelected { get; set; }

        public Student Student { get; set; }



    }
}