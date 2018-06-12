using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigiCore.Entities.UserManagement.Models
{
    [Table("AspNetUserLogins")]
    public class ApplicationUserLogin : IdentityUserLogin<int>
    {
    }
    [Table("AspNetUserClaims")]
    public class ApplicationUserClaim : IdentityUserClaim<int>
    { }
    [Table("AspNetRoleClaims")]
    public class ApplicationRoleClaim : IdentityRoleClaim<int>
    { }
    [Table("AspNetUserTokens")]
    public class ApplicationUserToken : IdentityUserToken<int>
    { }

}
