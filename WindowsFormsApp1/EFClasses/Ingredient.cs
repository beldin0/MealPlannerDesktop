using MealPlannerApp.Classes;
using MealPlannerApp.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealPlannerApp.EFClasses
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
        public static Ingredient NULL
        {
            get
            {
                return new Ingredient() { Name = null };
            }
        }

        //public char Type() { return 'I'; }

        public void DeleteFrom(IMealPlannerContext db)
        {
            if (Meals.Count > 0)
            {
                if (Dialogs.ConfirmDelete == DialogResult.No) { return; };
            }
            db.Delete(this);
        }

        public override string ToString()
        {
            string value = Name;
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

        public int CompareTo(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return 0;
            };
            Ingredient iObj = (Ingredient)obj;
            return Name.CompareTo(iObj.Name);
        }
    }
}

