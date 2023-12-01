using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Shape3D
    {
        public abstract double Volume();
        public abstract double GetSurfaceArea();
    }
    public class Cube : Shape3D
}
