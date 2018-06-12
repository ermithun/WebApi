using DigiCore.Entities.Enum;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigiCore.Entities.UserManagement.Models
{
    [Table("AspNetRoles")]
    public class ApplicationRole : IdentityRole<int>
    {
        [Required]
        [Display(Name = "Added By")]
        public int AddedBy { get; set; }

        [Required]
        [Display(Name = "Added On")]
        [Column(TypeName = "Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedOn { get; set; }

        [Required]
        [Display(Name = "Status")]
        public RowStatus Status { get; set; }

        [Required]
        [Display(Name = "Updated By")]
        public int UpdatedBy { get; set; }

        [Required]
        [Display(Name = "Updated On")]
        [Column(TypeName = "Datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedOn { get; set; }

        [ForeignKey("AddedBy")]
        public virtual ApplicationUser AppUserCreator { get; set; }

        [ForeignKey("UpdatedBy")]
        public virtual ApplicationUser AppUserUpdator { get; set; }
    }
}
