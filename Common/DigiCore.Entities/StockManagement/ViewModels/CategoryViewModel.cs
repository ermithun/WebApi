using DigiCore.Entities.CoreManagement;
using DigiCore.Entities.CoreManagement.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiCore.Entities.StockManagement.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string Description { get; set; }

        public int? SubCategoryId { get; set; }

        public string SubCategoryName { get; set; }

    }
}
