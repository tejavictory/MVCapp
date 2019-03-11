using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Degree
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeId { get; set; }
        public string DegreeAbbr { get; set; }
        public string DegreeName { get; set; }
        public int NumberOfTerms { get; set; }



    }
}