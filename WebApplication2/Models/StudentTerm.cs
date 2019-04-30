using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class StudentTerm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId { get; set; }
        public int StudentId { get; set; }
        [Range(1,10)]
        public int Term { get; set; }
        [StringLength(10)]
        public string TermAbbr { get; set; }
        [StringLength(10)]
        public string TermName { get; set; }
        public ICollection<Slot> PlanTermRequirements { get; set; }


        public Student Student { get; set; }


    }
}