using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiCore.Entities.StockManagement.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
