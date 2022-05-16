using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Interfaces
{
    public interface ISwitch
    {
        bool OnOff { get; }

        void TurnOn();
        void TurnOff();
    }
}
