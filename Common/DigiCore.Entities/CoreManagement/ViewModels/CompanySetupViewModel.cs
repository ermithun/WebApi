using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiCore.Entities.CoreManagement.ViewModels
{
    public class CompanySetupViewModel:BaseViewModel
    {
        [Key]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [DataType(DataType.Upload)]
        public byte[] CompanyLogo { get; set; }

        [Display(Name = "Logo")]
        public string Logo { get; set; }

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
