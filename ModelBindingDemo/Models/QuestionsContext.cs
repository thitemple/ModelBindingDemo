using System.Data.Entity;

namespace MvcApplicationCustomModelBinder.Models
{
    public class QuestionsContext : DbContext
    {
        public QuestionsContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}