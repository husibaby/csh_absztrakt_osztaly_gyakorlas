using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    //Absztrakt Dessert osztály
    public abstract class Dessert
    {   //Absztrakt Eat metódus
        public abstract void Eat();
    }
    //leszármazott osztály
    public class IceCream : Dessert
    {
        // Implementáljuk az Eat metódust a Cake osztályban
        public override void Eat()
        {
            Console.WriteLine("Szeretem a fagyit!");
        }
    }

    public class Cake : Dessert
    {
        public override void Eat()
        {
            Console.WriteLine("De a sütit még jobban szeretem!");
        }
    }
}
