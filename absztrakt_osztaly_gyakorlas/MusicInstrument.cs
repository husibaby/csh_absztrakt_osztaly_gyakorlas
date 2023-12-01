using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class MusicInstrument
    {
        public abstract void PlayMusic();
    }
    public class Piano : MusicInstrument
    {
        public override void PlayMusic()
        {
            Console.WriteLine("A zene zongorán szól.");
        }
    }

    public class Guitar : MusicInstrument
    {

        public override void PlayMusic()
        {
            Console.WriteLine("A zene gitáron szól.");
        }
    }
}
