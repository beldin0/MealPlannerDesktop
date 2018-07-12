namespace MealPlannerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DefaultQuantityType = c.String(),
                        IsCarb = c.Boolean(nullable: false),
                        IsProtein = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IngredientID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CookTime = c.String(),
                        MealType = c.Int(),
                    })
                .PrimaryKey(t => t.MealID);
            
            CreateTable(
                "dbo.MealIngredients",
                c => new
                    {
                        Meal_MealID = c.Int(nullable: false),
                        Ingredient_IngredientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Meal_MealID, t.Ingredient_IngredientID })
                .ForeignKey("dbo.Meals", t => t.Meal_MealID, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_IngredientID, cascadeDelete: true)
                .Index(t => t.Meal_MealID)
                .Index(t => t.Ingredient_IngredientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MealIngredients", "Ingredient_IngredientID", "dbo.Ingredients");
            DropForeignKey("dbo.MealIngredients", "Meal_MealID", "dbo.Meals");
            DropIndex("dbo.MealIngredients", new[] { "Ingredient_IngredientID" });
            DropIndex("dbo.MealIngredients", new[] { "Meal_MealID" });
            DropTable("dbo.MealIngredients");
            DropTable("dbo.Meals");
            DropTable("dbo.Ingredients");
        }
    }
}
