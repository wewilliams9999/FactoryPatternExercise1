using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new SUV();
                default:
                    return new SUV();
            }
            
 
           
        }
    }
}
