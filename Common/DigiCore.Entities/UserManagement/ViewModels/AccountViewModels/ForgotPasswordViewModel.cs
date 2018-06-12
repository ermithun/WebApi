﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DigiCore.Entities.UserManagement.ViewModels.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public string UserName { get; set; }
         
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
