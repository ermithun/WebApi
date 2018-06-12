using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.UserManagement.ViewModels.UserRoleViewModels
{
    public class UserRoleMapViewModel:BaseViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Display(Name ="Role Name")]
        public string RoleName { get; set; }

        [Required]
        [Display(Name ="From Date")]
        [Column(TypeName = "Datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; }

        [Required]
        [Display(Name ="To Date")]
        [Column(TypeName = "Datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ToDate { get; set; }
    }
}
