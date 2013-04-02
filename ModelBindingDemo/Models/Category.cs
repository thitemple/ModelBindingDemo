using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelBindingDemo.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        public virtual List<Question> Questions { get; set; }
    }
}