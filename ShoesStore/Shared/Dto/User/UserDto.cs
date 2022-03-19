using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dto.User
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string UserEmail { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public int PermissionId { get; set; }
    }
}
