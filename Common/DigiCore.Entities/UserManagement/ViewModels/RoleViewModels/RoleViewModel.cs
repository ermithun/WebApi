using DigiCore.Entities.CoreManagement.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiCore.Entities.UserManagement.ViewModels.RoleViewModels
{
    public class RoleViewModel  : BaseViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(15)]
        public string RoleName { get; set; }

        public int RoleId { get; set; }

        public RoleViewModel() { }

        public RoleViewModel(IdentityRole<int> role)
        {
            this.Id = role.Id;
            this.RoleName = role.Name;
        }
    }
}
