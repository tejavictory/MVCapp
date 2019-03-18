using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Slot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SlotId { get; set; }
        public int DegreePlanSelected { get; set; }
         [Range(1,10)]
        public int Term { get; set; }

        public int CreditId { get; set; }
         [StringLength(1)]
        public string Status { get; set; }
      
        public Credit Credit { get; set; }


    }
}