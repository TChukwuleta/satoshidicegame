﻿using Microsoft.AspNetCore.Identity;
using SatoshiDice.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatoshiDice.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Verified { get; set; }
        public decimal Balance { get; set; }
        public string UserId { get; set; }
        public Status Status { get; set; }
        public string StatusDesc { get { return Status.ToString(); } }
    }
}
