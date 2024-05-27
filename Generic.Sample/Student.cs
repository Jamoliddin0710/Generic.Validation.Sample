using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Sample
{
    public class Student
    {
        public int Id { get; set; }
        [Length(5,25)]
        public string FullName { get; set; }
        [Range(0,5)]
        public decimal GPA { get; set; }
        [AllowedValues("Single", "Married" , "Divorced")]
        public string MarriedStatus { get; set; }
    }
}
