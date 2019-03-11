using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class DegreeCredit
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeCreditId { get; set; }
        public int DegreeId { get; set; }
        public int CreditId { get; set; }

        public Degree Degree { get; set; }

        public Credit Credit { get; set; }



    }
}