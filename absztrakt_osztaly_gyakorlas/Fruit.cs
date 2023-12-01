using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Fruit
    {
        public abstract void Peel();
    }

    public class Banana : Fruit
    {
        public override void Peel()
        {
            Console.WriteLine("Banán pucolás");
        }
    }
    public class Orange : Fruit
    {
        public override void Peel()
        {
            Console.WriteLine("Narancs pucolás");
        }
    }

}
