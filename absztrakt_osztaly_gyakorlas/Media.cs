using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Media
    {
        public abstract void Play();

        // Nem absztrakt "getDuration" metódus
        public int GetDuration()
        {
            return 0;
        }

        public class Film : Media
        { 
            public override void Play()
            {
                Console.WriteLine("Film indítása...");
            }


        // Zene osztály, amely a Media absztrakt osztályból származik
        public class Music : Media
        {
       
            public override void Play()
            {
                Console.WriteLine("Zene indítása...");
            }

          
        }
    }
}
