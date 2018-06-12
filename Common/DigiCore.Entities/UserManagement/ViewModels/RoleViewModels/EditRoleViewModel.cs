using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiCore.Entities.UserManagement.ViewModels.RoleViewModels
{
    public class EditRoleViewModel //:BaseViewModel
    {
        public string OriginalRoleName { get; set; }

        public string Id { get; set; }
        public string RoleName { get; set; }



        public EditRoleViewModel() { }

        public EditRoleViewModel(IdentityRole role)
        {
            this.OriginalRoleName = role.Name;
            this.Id = role.Id;
            this.RoleName = role.Name;

        }
    }
}
