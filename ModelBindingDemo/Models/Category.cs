using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcApplicationCustomModelBinder.Models
{
    public class Category : Entity
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public virtual List<Question> Questions { get; set; }
    }
}