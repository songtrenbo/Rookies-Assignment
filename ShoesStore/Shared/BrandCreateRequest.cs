using System;
using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class BrandCreateRequest
    {
        [Required]
        public string BrandName { get; set; }
    }
}
