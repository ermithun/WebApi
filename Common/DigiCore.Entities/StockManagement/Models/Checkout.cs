using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using DigiCore.Entities.UserManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.StockManagement.Models
{
    [Table("Checkout")]
    public class Checkout : BaseModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }


        [Required]
        [Display(Name = "Checkout Qty")]
        public int CheckoutQty { get; set; }

        [Required]
        [Display(Name = "Unit Id")]
        public int UnitId { get; set; }


        [Column(TypeName = "Datetime"), DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CheckoutDate { get; set; }


        [Display(Name = "Staff Id")]
        public int? StaffId { get; set; }


        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("Staff_Id")]
        public virtual ApplicationUser Staff { get; set; }

        [ForeignKey("UnitId")]
        public virtual MeasuringUnit MeasuringUnit { get; set; }



    }
}
