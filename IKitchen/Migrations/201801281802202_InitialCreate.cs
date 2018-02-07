namespace IKitchen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MealName = c.String(),
                        MealType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Int(nullable: false),
                        DateTimeBought = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        MeasureType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductMeals",
                c => new
                    {
                        Product_ID = c.Int(nullable: false),
                        Meal_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_ID, t.Meal_ID })
                .ForeignKey("dbo.Products", t => t.Product_ID, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.Meal_ID, cascadeDelete: true)
                .Index(t => t.Product_ID)
                .Index(t => t.Meal_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductMeals", "Meal_ID", "dbo.Meals");
            DropForeignKey("dbo.ProductMeals", "Product_ID", "dbo.Products");
            DropIndex("dbo.ProductMeals", new[] { "Meal_ID" });
            DropIndex("dbo.ProductMeals", new[] { "Product_ID" });
            DropTable("dbo.ProductMeals");
            DropTable("dbo.Products");
            DropTable("dbo.Meals");
        }
    }
}
