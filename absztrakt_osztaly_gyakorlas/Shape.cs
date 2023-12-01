using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Shape
    {
        public abstract void Area();
    }

    public class Circle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Kör");
        }
    }

    public class Rectangle : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Téglalap");
        }
    }
}
