using System;
namespace DeclaringConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            // constant declaration 
            Double r;
            Console.WriteLine("Enter Radius: ");//input 
            r = Convert.ToDouble(Console.ReadLine());
            Double areaCircle = pi * r * r;
            Console.WriteLine("Radius: {0}, Area: {1}", r, areaCircle);
            Console.ReadLine();
        }
    }
}