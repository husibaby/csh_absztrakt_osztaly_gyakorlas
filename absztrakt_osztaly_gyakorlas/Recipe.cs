using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Recipe //mindenképpen kell a public szó a abstrac elé
    {
        public abstract void Cook();
    }

    public class PastaRecipe : Recipe
    {
        public override void Cook()
        {
            Console.WriteLine("Tésztát főz!");
        }
    }

    public class CakeRecipe : Recipe
    {
        public override void Cook()
        {
            Console.WriteLine("Süti süt!");
        }
    }
}
