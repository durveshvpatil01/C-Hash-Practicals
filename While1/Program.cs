using System;
namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 15;
            while (d <= 150)
            {
                Console.WriteLine("Value of a:{0}", d);
                d = d + 5;
            }
            Console.ReadLine();
        }
    }
}
