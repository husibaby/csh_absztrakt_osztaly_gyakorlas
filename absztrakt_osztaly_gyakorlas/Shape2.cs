using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absztrakt_osztaly_gyakorlas
{
    public abstract class Shape2
    {
        public void Draw();

        public virtual double GetArea()
        {
            return 0.0; // Alapértelmezett érték, amelyet a leszármazott osztályok felülírhatnak
        }
    }
    public class Circle : Shape2
    { 
    private double radius;

        // Konstruktor a Circle osztályhoz
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            Console.WriteLine("A kör rajzolása");
        }

        // Az override GetArea metódus megvalósítása a Circle osztályban
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    // Rectangle osztály, amely örökli az Shape osztályt
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

      
        public override void Draw()
        {
            Console.WriteLine("A téglalap rajzolása");
        }

        {
            return width * height;
        }
    }
}
