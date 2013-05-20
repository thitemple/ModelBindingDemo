namespace MvcApplicationCustomModelBinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removecolunaid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Questions", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Questions", new[] { "CategoryId" });
            RenameColumn(table: "dbo.Questions", name: "CategoryId", newName: "Category_CategoryId");
            AddForeignKey("dbo.Questions", "Category_CategoryId", "dbo.Categories", "CategoryId");
            CreateIndex("dbo.Questions", "Category_CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Questions", new[] { "Category_CategoryId" });
            DropForeignKey("dbo.Questions", "Category_CategoryId", "dbo.Categories");
            RenameColumn(table: "dbo.Questions", name: "Category_CategoryId", newName: "CategoryId");
            CreateIndex("dbo.Questions", "CategoryId");
            AddForeignKey("dbo.Questions", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
        }
    }
}
