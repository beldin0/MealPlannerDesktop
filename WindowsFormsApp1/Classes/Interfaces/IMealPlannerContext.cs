using System.Collections.Generic;
using System.Data.Entity;
using MealPlannerApp.EFClasses;

namespace MealPlannerApp.Classes
{
    public interface IMealPlannerContext
    {
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<Meal> Meals { get; set; }

        void Add(Ingredient i);
        void Add(Meal m);
        void Delete(Ingredient i);
        void Delete(Meal m);
        IEnumerable<Ingredient> GetIngredients();
        IEnumerable<Meal> GetMeals();
        void SaveChanges();
        void Dispose();
    }
}