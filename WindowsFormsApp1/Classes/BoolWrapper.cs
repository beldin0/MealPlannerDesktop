using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp.Classes
{
    internal class BoolWrapper : Wrapper<bool>
    {
        internal BoolWrapper(bool value = false) : base(value)
        {
        }
    }
}
