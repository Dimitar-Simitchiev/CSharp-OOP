using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InterfacesandAbstractionCars
{
    internal interface IElectricCar:ICar
    {
         int Battery { get; set; }
       

    }
}
