﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jwt_Token_Youtube
{
    public class User
    {
        public string UserName { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
