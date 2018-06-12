using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiCore.Entities.UserManagement.Models
{
    public class UserLoginHist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Login Date")]
        public DateTime LoginDate { get; set; }

        [Required]
        [Display(Name = "UserName")]
        [StringLength(50, MinimumLength = 0)]
        public string UserName { get; set; }

        [Display(Name = "Login Success")]
        public bool Loginsuccess { get; set; }

        [Display(Name = "Logout Date")]
        public DateTime? LogoutDate { get; set; }

        [Display(Name = "Ip Address")]
        [StringLength(50, MinimumLength = 0)]
        public string IpAddress { get; set; }

        [Display(Name = "Session Id")]
        [StringLength(100, MinimumLength = 0)]
        public string SessionId { get; set; }

        [Display(Name = "Remarks")]
        [StringLength(200, MinimumLength = 0)]
        public string Remarks { get; set; }
    }
}
