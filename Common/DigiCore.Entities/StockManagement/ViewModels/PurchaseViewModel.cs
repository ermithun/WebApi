using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.StockManagement.ViewModels
{
    public class PurchaseViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Qty")]
        public int Qty { get; set; }

        [Required]
        [Display(Name = "Unit Id")]
        public int UnitId { get; set; }

        [Display(Name = "Unit Name")]
        public string UnitName { get; set; }

        [Required]
        [Display(Name = "Rate")]
        public decimal Rate { get; set; }

        [Required]
        [Column(TypeName = "Datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Supplier Id")]
        public int? SupplierId { get; set; }

        [Display(Name = "SupplierName")]
        public string SupplierName { get; set; }
    }
}
