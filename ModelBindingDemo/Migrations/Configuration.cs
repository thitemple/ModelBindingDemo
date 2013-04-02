namespace ModelBindingDemo.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.QuestionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.QuestionsContext context)
        {
            context.Categories.AddOrUpdate(
                c => c.CategoryName,
                new Models.Category { CategoryName = "Very important" },
                new Models.Category { CategoryName = "Important" },
                new Models.Category { CategoryName = "Not important" });
        }
    }
}
