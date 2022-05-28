using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class RefreshTokenModel
    {
        public string UserName { get; set; }
        public string PermissionName { get; set; }
        public string RefreshToken { get; set; }
    }
}
