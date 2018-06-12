using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.CoreManagement.Models
{
    [Table("CompanySetup")]
    public class CompanySetup : BaseModel
    {
        [Key]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [DataType(DataType.Upload)]
        public byte[] CompanyLogo { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Company Address")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Address1 { get; set; }

        [Required]
        [Display(Name = "Company Address2")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Address2 { get; set; }

        [Required]
        [Display(Name = "Company PhoneNo")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string PhoneNo { get; set; }

        [Required]
        [Display(Name = "Company Email")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Company WebSite")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Website { get; set; }


        [Required]
        [Display(Name = "Theme Id")]
        public int ThemeId { get; set; }
    }
}
