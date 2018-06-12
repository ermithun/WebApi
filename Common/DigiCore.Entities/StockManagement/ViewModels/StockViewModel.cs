using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiCore.Entities.StockManagement.ViewModels
{
    public class StockViewModel
    {
        public int Id { get; set; } 
        [Required]
        public int ProductId { get; set; }

        [StringLength(40)]
        public string ProductName { get; set; }

        [Required]
        public int UnitId { get; set; }

        [StringLength(20)]
        public string UnitName { get; set; } 

        [Required]
        public int RemainingQty { get; set; }
    }
}
