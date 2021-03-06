using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class DegreePlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }
        [DisplayName("Student")]
        public int StudentId { get; set; }
        [DisplayName("Plan")]
        public string DegreePlanAbbr { get; set; }
        [DisplayName("Plan Name")]
        [StringLength(25)]
        public string DegreePlanName { get; set; }
        public int DegreePlanSelected { get; set; }
        public int DegreeId { get; set; }

        public ICollection<StudentTerm> PlanTerms { get; set; }


        public Degree Degree { get; set; }
        public Student Student { get; set; }



    }
}