using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{ 
    public abstract class GameCharacter
    {
 
        public abstract void Attack();
    }


    public class Warrior : GameCharacter
    {
        public override void Attack()
        {
            Console.WriteLine("A harcos támad!");
        }
    }
    public class Mage : GameCharacter
    {
        public override void Attack()
        {
            Console.WriteLine("A mágus varázsol!");
        }
    }
}
