using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Motorcycle : IVehicle
    {
        void IVehicle.Drive()
        {
            Console.WriteLine("Hey, look at me - I'm driving a motorcycle!");
        }
    }
}
