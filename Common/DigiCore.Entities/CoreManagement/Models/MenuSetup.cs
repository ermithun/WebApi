using DigiCore.Entities.CoreManagement.Models;
using DigiCore.Entities.UserManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.CoreManagement.Models
{
    [Table("MenuSetup")]
    public class MenuSetup
    {
        [Key]
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Mast Menu ID")]
        public int MastMenuID { get; set; }

        [Required]
        [Display(Name = "Menu Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string MenuName { get; set; }

        [Required]
        [Display(Name = "Is Menu Group")]
        public bool IsMenuGroup { get; set; }

        [Required]
        [Display(Name = "Sort Order")]
        public int SortOrder { get; set; }

        [Required]
        [Display(Name = "Menu Icon")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string MenuIcon { get; set; }

        [Display(Name = "Module Id")]
        public int? ModuleId { get; set; }

        [Required]
        [Display(Name = "Menu Version")]
        public int MenuVersion { get; set; }

        [Required]
        [Display(Name = "IsHidden")]
        public bool IsHidden { get; set; }

        [Required]
        [Display(Name = "Updated By")]
        public int UpdatedBy { get; set; }

        [Required]
        [Display(Name = "Updated On")]
        [Column(TypeName = "datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdateOn { get; set; }

        //ForeignKey
        [ForeignKey("ModuleId")]
        public virtual Module Module { get; set; }

        [ForeignKey("UpdatedBy")]
        public virtual ApplicationUser AppUserUpdator { get; set; }
    }
}
