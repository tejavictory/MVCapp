using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Family { get; set; }
        public string Given { get; set; }
        public int N919 { get; set; }



    }
}