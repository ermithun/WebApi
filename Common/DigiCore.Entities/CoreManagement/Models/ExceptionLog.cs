using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DigiCore.Entities.CoreManagement.Models
{
    [Table("ExceptionLog")]
    public class ExceptionLog
    {
        [Required]
        [Display(Name = "Id")]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Display(Name = "Message")]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Message { get; set; }

        [Display(Name = "Inner Message")]
        [Column(Order = 2)]
        [StringLength(500)]
        public string InnerMessage { get; set; }

        [Display(Name = "Source")]
        [Column(Order = 3)]
        [StringLength(500)]
        public string Source { get; set; }

        [Display(Name = "Stack Trace")]
        [Column(Order = 4)]
        public string StackTrace { get; set; }

        [Display(Name = "Datetime")]
        [Column(Order = 5)]
        public DateTime DateTime { get; set; }

        [Display(Name = "Module Name")]
        [Column(Order = 6)]
        [StringLength(300)]
        public string ModuleName { get; set; }
    }
}
