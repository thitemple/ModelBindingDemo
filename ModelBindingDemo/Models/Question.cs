using System.ComponentModel.DataAnnotations;

namespace ModelBindingDemo.Models
{
    public class Question
    {
        [Required]
        public int QuestionId { get; set; }

        [Required]
        [Display(Name = "Question Text")]
        public string QuestionText { get; set; }

        [Required]
        public string Answer { get; set; }

        public virtual Category Category { get; set; }
    }
}