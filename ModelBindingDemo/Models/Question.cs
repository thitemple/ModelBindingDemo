using System.ComponentModel.DataAnnotations;

namespace MvcApplicationCustomModelBinder.Models
{
    public class Question : Entity
    {
        [Required]
        public int QuestionId { get; set; }

        [Required]
        public string QuestionText { get; set; }

        [Required]
        public string Answer { get; set; }

        public virtual Category Category { get; set; }
    }
}