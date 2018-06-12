using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiCore.Entities.StockManagement.ViewModels
{
    public class SupplierViewModel : BaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string TelePhone { get; set; } 
        [EmailAddress]
        public string Email { get; set; }
        public string Pan_Info { get; set; }
    }

}
