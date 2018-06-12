using DigiCore.Entities.UserManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.CoreManagement.Models
{
    [Table("Module")]
    public class Module
    {
        [Key]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Module Name")]
        [StringLength(75, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string ModuleName { get; set; }

        [Required]
        [Display(Name = "Area Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string AreaName { get; set; }

        [Display(Name = "Description")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Updated By")]
        public int UpdatedBy { get; set; }

        [Required]
        [Display(Name = "Updated On")]
        [Column(TypeName = "datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdateOn { get; set; }


        [ForeignKey("UpdatedBy")]
        public virtual ApplicationUser AppUserUpdator { get; set; }

       // public virtual List<ActivityLogHist> ActivityLogHist { get; set; }
    }
}
