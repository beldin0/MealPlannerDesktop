using MealPlannerApp.Classes;
using System;
using System.Collections.Generic;

namespace MealPlannerApp.EFClasses
{
    public class Meal : IMealComponent
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int MealID { get; set; }
        public string Name { get; set; }
        private string _CookTime;
        public string CookTime
        {
            get { return _CookTime; }
            set
            {
                if (value == null || CookingTime.GetCookTimes().Contains(value))
                {
                    _CookTime = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Type? MealType { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }
        public static Meal NULL
        {
            get
            {
                return new Meal() { Name = null, Ingredients = new List<Ingredient>() };
            }
        }

        public override string ToString()
        {
            return Name + " [" + (Ingredients == null ? 0 : Ingredients.Count) + "]";
        }

        public void DeleteFrom(IMealPlannerContext db)
        {
            db.Delete(this);
        }

        //char IMealComponent.Type()
        //{
        //    return 'M';
        //}

        public IEnumerable<IMealComponent> GetLinkedComponents()
        {
            List<Ingredient> list = Ingredients;
            return list ?? new List<Ingredient>();
        }

        internal List<Ingredient> Carbs
        {
            get
            {
                List<Ingredient> list = new List<Ingredient>();
                foreach (Ingredient i in Ingredients)
                {
                    if (i.IsCarb) list.Add(i);
                }
                return list;
            }
        }

        internal List<Ingredient> Proteins
        {
            get
            {
                List<Ingredient> list = new List<Ingredient>();
                foreach (Ingredient i in Ingredients)
                {
                    if (i.IsProtein) list.Add(i);
                }
                return list;
            }
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

        public int CompareTo(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return 0;
            };
            Meal iObj = (Meal)obj;
            return Name.CompareTo(iObj.Name);
        }
    }
}
