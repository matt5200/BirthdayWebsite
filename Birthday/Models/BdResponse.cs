using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Birthday.Models
{
    public class BdResponse
    {
        [Required(ErrorMessage = "Please enter your From")]
        public string From { get; set; }
        [Required(ErrorMessage = "Please enter your To")]
        public string To { get; set; }
        [Required(ErrorMessage = "Please enter your Message")]
        public string Message { get; set; }
    }
}
