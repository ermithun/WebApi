using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.StockManagement.Models
{
    [Table("Purchase")]
    public  class Purchase :BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Product Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name ="Purchase Qty")]
        public int PurchaseQty { get; set; }

        [Required]
        [Display(Name = "Unit Id")]
        public int UnitId { get; set; }

        [Required]
        [Display(Name = "Rate")]
        public decimal Rate { get; set; }

        [Required]
        [Column(TypeName = "Datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Supplier Id")]
        public int? SupplierId { get; set; }

        [ForeignKey("ProductId")] 
        public virtual Product Product { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; } 

        [ForeignKey("UnitId")]
        public virtual MeasuringUnit MeasuringUnit { get; set; }
    }
}
