using System.Data.Entity;

namespace ModelBindingDemo.Models
{
    public class QuestionsContext : DbContext
    {
        public QuestionsContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}