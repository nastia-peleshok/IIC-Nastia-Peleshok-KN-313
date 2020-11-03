using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Domain.Entities
{
    public class ServiceItem: EntityBase
    {
        [Required(ErrorMessage ="Enter name of meals")]
        [Display(Name="Name of meal")]
        public override string Title { get; set; }
        [Display(Name = "Short description of meal")]
        public override string Subtitle { get; set; }
        [Display(Name = "Content of page")]
        public override string Text { get; set; } 
    }
}
