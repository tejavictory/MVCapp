using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        [DisplayName("Family Name")]
        [StringLength(15)]
        public string Family { get; set; }
        [DisplayName("Given Name")]
        [StringLength(25)]
        public string Given { get; set; }
        public int N919 { get; set; }

        public ICollection<DegreePlan> DegreePlans { get; set; }



    }
}