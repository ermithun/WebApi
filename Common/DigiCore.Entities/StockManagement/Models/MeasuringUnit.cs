using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.StockManagement.Models
{
    [Table("Measuring")]
    public class MeasuringUnit:BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; } 
    }
}
