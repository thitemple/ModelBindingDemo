using MvcApplicationCustomModelBinder.Models;

namespace MvcApplicationCustomModelBinder.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<QuestionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuestionsContext context)
        {
            context.Categories.AddOrUpdate(
                c => c.CategoryName,
                new Category { CategoryName = "Very important" },
                new Category { CategoryName = "Important" },
                new Category { CategoryName = "Not important" });
        }
    }
}
