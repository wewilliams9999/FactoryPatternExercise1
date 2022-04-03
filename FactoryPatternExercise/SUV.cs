using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class SUV : IVehicle
    {
        void IVehicle.Drive()
        {
            Console.WriteLine("Hey, look at me - I'm driving an SUV!");
        }
    }
}
