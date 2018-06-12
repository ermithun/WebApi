using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.StockManagement.Models
{
    [Table("Category")]
    public class Category :BaseModel
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public Category SubCategory { get; set; } 
    }
}
