using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * Title of Program 
 * Your Name, Date
 * Introduction to Programming
 */


namespace RobotWorldDomination
{
    class Program
    {
        static void Main()
        {
            Companion sideKick = new Companion();
            sideKick.Name = "Larry";
            sideKick.Talk("hello");

            Robot.Run();

        }
    }
    class Companion
    {
        public string Name = "";

        public void Talk(string message)
        {
            Console.WriteLine(Name + " says " + message);
        }

    }
    class Robot
    {
        //attributes
        static public string Name = "Henry";
        static public string MetalType = "Steel";
        static public double Weight = 700.07;
        static public string Color = "Purple";
        static public string Purpose = "Destruction";

        //methods
        static public void Run()
        {
            Console.Title = "Super Awesome Robot App";
            Console.WriteLine("Your robot's name is " + Name + ", enter a new name.");
            Console.Write("Robot Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Your robot's name now is " + Name);

            Console.WriteLine("Your robot's color is " + Color + ", enter a new color.");
            Color = Console.ReadLine();
            Console.WriteLine("Your robot's color is now " + Color);

            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();


            Console.Title = "Super Awesome " + Name + " App";

            

            Fly();
            BreatheFire();
            LaserVision();

            Console.ReadKey();
        }
        static public void Fly()
        {
            Console.WriteLine(Name + ", the " + Color + " " + MetalType + " robot, flies.");
        }

        static public void BreatheFire()
        {
            Console.WriteLine(Name + ", the " + Color + " " + MetalType + " robot, breathes fire.");
        }
        static public void LaserVision()
        {
            Console.WriteLine(Name + ", the " + Color + " " + MetalType + " robot, lasers your vision.");
        }
    }
}
