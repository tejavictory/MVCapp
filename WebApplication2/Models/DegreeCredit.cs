using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class DegreeCredit
    {

        [Key]
        public int DegreeCreditID { get; set; }
        public int DegreeID { get; set; }
        public int CreditID { get; set; }    


    }
}