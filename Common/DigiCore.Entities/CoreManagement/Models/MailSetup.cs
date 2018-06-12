using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiCore.Entities.CoreManagement.Models
{
    public class MailSetup :BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string SmtpHost { get; set; }
        [Required]
        public int SmtpPort { get; set; }
        [Required]
        public bool UseSSL { get; set; }


    }
}
