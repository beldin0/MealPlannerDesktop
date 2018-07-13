using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp
{
    public interface IMealComponent : IComparable
    {
        char Type();
        IEnumerable<IMealComponent> GetLinkedComponents();
    }
}
