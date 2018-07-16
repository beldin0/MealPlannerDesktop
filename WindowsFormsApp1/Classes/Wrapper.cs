using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlannerApp.Classes
{
    internal class Wrapper<T>
    {
        internal T Value { get; set; }
        internal Wrapper(T value) { Value = value; }
        public static implicit operator T (Wrapper<T> wrapper)
        {
            if (wrapper == null)
            {
                return default(T);
            }
            return wrapper.Value;
        }
    }
}
