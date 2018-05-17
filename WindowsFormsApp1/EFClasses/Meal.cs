using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class Meal : IMealComponent
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int MealID { get; set; }
        public string Name { get; set; }
        private string _CookTime;
        public string CookTime {
            get { return _CookTime; }
            set
            {
                if (value == null || CookingTime.GetCookTimes().Contains(value))
                {
                    _CookTime = value;
                } else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Type? MealType { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }

        public override string ToString()
        {
            if (Ingredients == null) Program.db.Entry(this).Collection("Ingredients").Load();
            return Name + " [" + (Ingredients == null ? 0 : Ingredients.Count) + "]";
        }

        char IMealComponent.Type()
        {
            return 'M';
        }

        public IEnumerable<IMealComponent> GetLinkedComponents()
        {
            List<Ingredient> list = Ingredients;
            return list ?? new List<Ingredient>();
        }

        internal static Func<bool> GetAddDelegate(Meal m)
        {
            return delegate () {
                BooleanPasser bp = new BooleanPasser();
                AddMeal addDialog = new AddMeal { ReturnedBool = bp, StarterMeal = m };
                addDialog.ShowDialog();
                return bp.Value;
            };
        }

        internal string GetCarb()
        {
            if (Ingredients == null) Program.db.Entry(this).Collection("Ingredients").Load();
            foreach (Ingredient i in Ingredients)
            {
                if (i.IsCarb) return i.Name;
            }
            return "";
        }

        internal string GetProtein()
        {
            if (Ingredients == null) Program.db.Entry(this).Collection("Ingredients").Load();
            foreach (Ingredient i in Ingredients)
            {
                if (i.IsProtein) return i.Name;
            }
            return "";
        }

        public enum Type { Soup, Roast, }

        public static class CookingTime
        {
            public static readonly string UNDER_TWENTY_MINUTES = "Under 20 minutes";
            public static readonly string UNDER_FORTY_MINUTES = "20 to 40 minutes";
            public static readonly string UNDER_AN_HOUR = "40 minutes to an hour";
            public static readonly string OVER_AN_HOUR = "Over an hour";

            public static List<string> GetCookTimes()
            {
                return new List<string>(new string[] { UNDER_TWENTY_MINUTES, UNDER_FORTY_MINUTES, UNDER_AN_HOUR, OVER_AN_HOUR });
            }
        }
    }
}
