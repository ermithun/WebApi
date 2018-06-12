using DigiCore.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiCore.Entities.CoreManagement.Base
{
    public class BaseViewModel
    {
        [Display(Name = "Status")]
        public RowStatus Status { get; set; }

        [Display(Name = "AddedOn")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedOn { get; set; }

        [Display(Name = "AddedBy")]
        public int AddedBy { get; set; }

        [Display(Name = "AddedBy Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string AddedByName { get; set; }

        [Display(Name = "UpdatedOn")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdatedOn { get; set; }

        [Display(Name = "UpdatedBy")]
        public int UpdatedBy { get; set; }


        [Display(Name = "UpdateBy Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string UpdatedByName { get; set; }

    }
}
