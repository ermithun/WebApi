
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.UserManagement.Models
{
    public class UserRoleMap:BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int RoleId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser AppUser { get; set; }
        [ForeignKey("RoleId")]
        public virtual ApplicationRole AppRole { get; set; }
    }
}
