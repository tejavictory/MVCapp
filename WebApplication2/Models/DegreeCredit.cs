using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class DegreeCredit
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreeCreditId { get; set; }
        [DisplayName("Degree")]
        public int DegreeId { get; set; }
        [DisplayName("Credit")]
        public int CreditId { get; set; }

        public Degree Degree { get; set; }

        public Credit Credit { get; set; }



    }
}