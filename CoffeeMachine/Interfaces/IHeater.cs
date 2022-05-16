using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Interfaces
{
    public interface IHeater
    {
        int Degrees { get; }

        void SetDegrees(int degrees);
    }
}
