using System;
namespace Dowhileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = 30;
            do
            {
                Console.WriteLine("Value of a:{0}", D);
                D = D + 1;
            }
            while (D < 55);
            Console.ReadLine();
        }
    }
}