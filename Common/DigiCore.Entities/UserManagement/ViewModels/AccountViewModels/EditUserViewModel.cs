using DigiCore.Entities.CoreManagement.Base;
using DigiCore.Entities.Enum;
using DigiCore.Entities.UserManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiCore.Entities.UserManagement.ViewModels.AccountViewModels
{
    public class EditUserViewModel :BaseViewModel
    {
        public EditUserViewModel() { }
        // Allow Initialization with an instance of ApplicationUser:
        public EditUserViewModel(ApplicationUser user)
        {
            this.UserName = user.UserName;
            this.Id = user.Id;
            this.Status = user.Status;
            this.PhoneNumber = user.PhoneNumber;
            this.EmailId = user.Email;
            this.AddedOn = user.AddedOn;
        }

        public int Id { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }

        public bool IsActive { get; set; }
    }
}
