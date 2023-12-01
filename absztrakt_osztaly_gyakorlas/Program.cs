using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static absztrakt_osztaly_gyakorlas.Media.Film;
using static absztrakt_osztaly_gyakorlas.Media;
using static System.Net.Mime.MediaTypeNames;

namespace absztrakt_osztaly_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cake osztály
            Dessert iceCream = new IceCream();
            iceCream.Eat();
            Dessert cake = new Cake();
            cake.Eat();


            //Recipe osztály
            Recipe pastaRecipe = new PastaRecipe();
            pastaRecipe.Cook();
            Recipe cakeRecipe = new CakeRecipe();
            cakeRecipe.Cook();


            //Shape osztály
            Circle circle = new Circle(5.0);
            Console.WriteLine("A kör területe: " + circle.CalculateArea());
            Rectangle rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine("A téglalap területe: " + rectangle.CalculateArea());


            //Animal osztály
            Animal dog = new Dog();
            dog.makeSound(); // A kutya ugat!
            Animal cat = new Cat();
            cat.makeSound(); // A macska nyávog!


            //Vehicle osztály
            Car car = new Car();
            car.StartEngine(); // Az autó motorja elindult.
            Bicycle bicycle = new Bicycle();
            bicycle.StartEngine(); // A bicikli nincs motorral ellátva, nincs elindítható motorja.

            // Példa példányosításra és használatra
            Manager manager = new Manager(40000, 90000);
            Console.WriteLine("A vezető fizetése: " + manager.CalculateSalary());


            //Employee osztály
            Developer developer = new Developer(35, 180);
            Console.WriteLine("A fejlesztő fizetése: " + developer.CalculateSalary());


            //MusicInstrument osztály
            MusicInstrument piano = new Piano();
            piano.PlayMusic(); // "A zene zongorán szól.

            MusicInstrument guitar = new Guitar();
            guitar.PlayMusic(); // A zene gitáron szól.


            //Device osztály
            Device television = new Television();
            television.TurnOn(); 
            Device computer = new Computer();
            computer.TurnOn();

            // Gamer osztály
            GameCharacter warrior = new Warrior();
            warrior.Attack(); 

            GameCharacter mage = new Mage();
            mage.Attack();



            //Ftuit osztály
            Fruit banana = new Banana();
            banana.Peel();
            Fruit orange = new Orange();
            orange.Peel();


            //Food osztály
            Food soup = new Soup();
            soup.Cook();  
            soup.Serve(); 

            Food pizza = new Pizza();
            pizza.Cook();  
            pizza.Serve();


            //Document osztály
            Document textDocument = new TextDocument();
            textDocument.Print(); 
            textDocument.Save();  

            Document pdfDocument = new PDFDocument();
            pdfDocument.Print();
            pdfDocument.Save();


            //Media osztály
            Media film = new Film();
            film.Play();
            int filmDuration = film.GetDuration();
            Console.WriteLine("Film időtartama: " + filmDuration + " perc");

            Media music = new Music();
            music.Play();
            int musicDuration = music.GetDuration();
            Console.WriteLine("Zene időtartama: " + musicDuration + " perc");
        }
    }
    
}
