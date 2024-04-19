using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarker_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("pay mode Id")]
        public int Id { get; set; }
        [DisplayName("pay mode Name")]
        [Required(ErrorMessage= "Pay mode name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Pay Mode name must be between 3 and 50 characters")]
        public string Name { get; set; }
        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay mode Observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay Mode Observation must be between 3 and 200 characters")]
        public string Description { get; set; }
}
}
