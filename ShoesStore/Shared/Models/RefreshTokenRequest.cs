﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class RefreshTokenRequest
    {
        public string UserName { get; set; }

        public string RefreshToken { get; set; }
    }
}
