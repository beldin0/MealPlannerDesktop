using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp
{
    public class Ingredient : IMealComponent
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IngredientID { get; set; }
        public string Name { get; set; }
        public string DefaultQuantityType { get; set; }
        public bool IsCarb { get; set; }
        public bool IsProtein { get; set; }

        public virtual List<Meal> Meals { get; set; }

        public char Type() { return 'I'; }

        public override string ToString()
        {
            if (Meals==null) Program.db.Entry(this).Collection("Meals").Load();
            string value = Name;
            value += DefaultQuantityType == null ? "" : " (" + DefaultQuantityType + ")";
            value += (IsCarb? " [C]" : IsProtein? " [P]" : "");
            return value;
        }

        public override bool Equals(object o)
        {
            if (o == null || GetType() != o.GetType())
            {
                return false;
            }
            else
            {
                Ingredient i = (Ingredient)o;
                if (!String.Equals(i.Name, Name, StringComparison.CurrentCultureIgnoreCase)
                    || !String.Equals(i.DefaultQuantityType, DefaultQuantityType, StringComparison.CurrentCultureIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public IEnumerable<IMealComponent> GetLinkedComponents()
        {
            return Meals ?? new List<Meal>();
        }
    }
}

