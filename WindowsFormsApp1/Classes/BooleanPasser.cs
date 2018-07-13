using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp.Classes
{
    internal class BooleanPasser
    {
        internal bool Value { get; set; }
        internal IMealComponent Component { get; set; }
        internal bool HasComponent
        {
            get
            {
                return Component != null;
            }
        }
    }
}
