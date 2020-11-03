using System.ComponentModel.DataAnnotations;

namespace Restaurant.Domain.Entities
{
    public class TextField: EntityBase
    {
        [Required]
        public string CodeWord { get; set; }
        [Display(Name = "Name of page(Title)")]
        public override string Title { get; set; } = "Information page";
        [Display(Name = "Content of page")]
        public override string Text { get; set; } = "Content is filled by administrator";
        
    }
}
