using MealPlannerApp.EFClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MealPlannerApp.Classes
{
    public class LocalDbContext : DbContext, IMealPlannerContext
    {
        public LocalDbContext() : base("Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MealPlannerDb\Database.sdf")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = true;
        }

        public new void SaveChanges() => base.SaveChanges();
        public new void Dispose() => base.Dispose(true);

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }

        public IEnumerable<Ingredient> GetIngredients()
        {
            return Ingredients.Include("Meals");
        }

        public IEnumerable<Meal> GetMeals()
        {
            return Meals.Include("Ingredients");
        }

        public void Delete(Ingredient i)
        {
            Ingredients.Remove(i);
            SaveChanges();
        }

        public void Delete(Meal m)
        {
            Meals.Remove(m);
            SaveChanges();
        }

        public void Add(Meal m)
        {
            Meals.Add(m);
            SaveChanges();
        }

        public void Add(Ingredient i)
        {
            Ingredients.Add(i);
            SaveChanges();
        }
    }
}
