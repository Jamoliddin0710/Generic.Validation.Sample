using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidatorLibrary;

namespace Generic.Sample
{
    public class Payment
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [DateAttribute]
        public DateTime RecievedDateTime { get; set; }
    }
}
