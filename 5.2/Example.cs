using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal static class Example
    {
        [Flags]
        public enum CarVendor
        {
            Sedan = 1,
            Dragster = 2,
            SuperCar = 4,
            Minivan = 8,
            PickupTruck = 16,
            Jeep = 32,
            ElectricCar = 64 ,
            Crossover = 128,
            Limousine = 256,
        };

        public enum CarVendorWithoutFlags
        {
            Sedan = 1,
            Dragster = 2,
            SuperCar = 4,
            Minivan = 8,
            PickupTruck = 16,
            Jeep = 32,
            ElectricCar = 64,
            Crossover = 128,
            Limousine = 256,
        };
    }
}
