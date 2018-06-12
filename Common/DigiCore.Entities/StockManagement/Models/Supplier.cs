using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.StockManagement.Models
{
    [Table("Supplier")]
    public class Supplier:BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required] 
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        [StringLength(20)]
        public string TelePhone { get; set; }
        [EmailAddress]
        [StringLength(60)]
        public string Email { get; set; }

        public string PanInfo { get; set; }
    }
}
