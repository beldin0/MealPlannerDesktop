using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp.Classes.Interfaces
{
    interface IShoppingManager
    {
        string LoginUserName { set; }
        string LoginPassword { set; }

        void DoShopping(List<string> shopping);

        void Deregister();
    }
}
