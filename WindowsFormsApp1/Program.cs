using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static MealPlannerContext db;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            db = new MealPlannerContext();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
    class MealPlannerContext : DbContext
    {
        public MealPlannerContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database\Database.mdf;Integrated Security=True;Connect Timeout=30")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = true;
        }

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

        public void Delete (Ingredient i)
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
