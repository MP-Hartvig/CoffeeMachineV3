using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Interfaces
{
    public interface IFilter
    {
        bool FilterInserted { get; }

        void AddFilter();
        void RemoveFilter();
    }
}
