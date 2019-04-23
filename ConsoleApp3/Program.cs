using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            float Length;
            float Width;
            float Area;
            float Perimeter;
            float Height;
            float Volume;
            char Continue;

            Console.WriteLine("Enter Height:");
            Height = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Length:");
            Length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width:");
            Width = float.Parse(Console.ReadLine());
        
            Area = (Length * Width);
            Console.WriteLine("Area: " + Area);

            Console.WriteLine("Continue? (y/n)");

            Perimeter = (2 * Length) + (2 * Width);
            Console.WriteLine("Perimeter: " + Perimeter);

            Volume = (Length * Width * Height);
            Console.WriteLine("Volume: " + Volume);

            Console.ReadKey();
        }
    }
}
