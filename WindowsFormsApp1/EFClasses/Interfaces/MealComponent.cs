using MealPlannerApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp
{
    public interface IMealComponent : IComparable
    {
        void DeleteFrom(IMealPlannerContext db);
        IEnumerable<IMealComponent> GetLinkedComponents();
    }
}
