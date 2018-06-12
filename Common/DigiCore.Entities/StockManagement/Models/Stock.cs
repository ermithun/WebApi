using DigiCore.Entities.CoreManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.StockManagement.Models
{
    [Table("Stock")]
    public class Stock  //:BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int UnitId { get; set; }
        [Required]
        public int RemainingQty { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        

        [ForeignKey("UnitId")]
        public virtual MeasuringUnit MeasuringUnit { get; set; }
    }
}
