using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Food
    {

        public abstract void Cook();

        public void Serve()
        {
            Console.WriteLine("Felszolgálva");
        }
    }

    public class Soup : Food
    {

        public override void Cook()
        {
            Console.WriteLine("A leves elkészült.");
        }
    }

    public class Pizza : Food
    {
        public override void Cook()
        {
            Console.WriteLine("A pizza elkészült.");
        }
    }
}
