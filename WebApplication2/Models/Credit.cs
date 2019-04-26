using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Credit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditId { get; set; }
        [StringLength(10)]
        public string CreditAbbr { get; set; }
        [StringLength(20)]
        public string CreditName { get; set; }
        [Range(0,1)]
        public int IsSummer { get; set; }
        [Range(0, 1)]
        public int IsSpring { get; set; }
        [Range(0, 1)]
        public int IsFall { get; set; }
        


    }
}