using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Document
    {
        public abstract void Print();

        public void Save()
        {
            Console.WriteLine("A dokumentum el van mentve.");
        }
    }
    public class TextDocument : Document
    {
        public override void Print()
        {
            Console.WriteLine("A szöveges dokumentum nyomtatása.");
        }
    }

    public class PDFDocument : Document
    {
        public override void Print()
        {
            Console.WriteLine("A PDF dokumentum nyomtatása.");
        }
    }

}
