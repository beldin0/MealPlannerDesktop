using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IMealComponent
    {
        char Type();
        IEnumerable<IMealComponent> GetLinkedComponents();
    }
}
