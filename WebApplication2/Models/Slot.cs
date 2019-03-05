using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Slot
    {
        [Key]
        public int SlotID { get; set; }
        public int DegreePlanSelected { get; set; }
        public int Term { get; set; }
        public int CreditID { get; set; }
        public string Status { get; set; }
       
    }
}