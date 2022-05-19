using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class LoginRequest
    {
        [Required]
        [Display(Name = "Enter User Name")]

        public string UserName { get; set; }

        [Required]
        [Display(Name = "Enter Password")]
        public string Password { get; set; }
    }
}
