﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMDS.DAL.Entities.Auth
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int? ProfileId { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual UserProfile Profile { get; set; }
        public virtual ICollection<UserConnections> UserConnections { get; set; }
    }
}
