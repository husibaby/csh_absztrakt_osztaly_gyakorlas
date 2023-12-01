using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Device
    {
        public abstract void TurnOn();
    }

    public class Television : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("A televízió bekapcsolt állapotban van");
        }
    }
    public class Computer : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("A számítógép bekapcsolt állapotban van.");
        }
    }
}
    
