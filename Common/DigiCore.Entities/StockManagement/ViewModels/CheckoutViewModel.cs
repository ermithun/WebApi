using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.StockManagement.ViewModels
{
    public class CheckoutViewModel :BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Checkout Qty")]
        public int CheckoutQty { get; set; }

        [Required]
        [Display(Name = "Unit Id")]
        public int UnitId { get; set; }

        [Display(Name = "Unit Name")]
        public string UnitName { get; set; }

        [Required]
        [Column(TypeName = "Datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckoutDate { get; set; } 

        [Required]
        [Display(Name = "Staff Id")]
        public int? StaffId { get; set; }

        [Display(Name = "Staff Name")]
        public string StaffName { get; set; } 
    }
}
