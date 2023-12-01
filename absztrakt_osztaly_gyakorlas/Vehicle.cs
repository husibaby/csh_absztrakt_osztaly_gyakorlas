using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
    }
    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Az autó motorja elindult.");
        }
    }

    public class Bicycle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("A bicikli nincs motorral ellátva, nincs elindítható motorja.");
        }
    }

}
