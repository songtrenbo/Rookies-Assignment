using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class CategoryCreateRequest
    {
        [Required]
        public string CategoryName { get; set; }

        public string Description { get; set; }

    }
}
