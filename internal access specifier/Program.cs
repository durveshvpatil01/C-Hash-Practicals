using System;

namespace internal_access_specifier
{
    class Rectangle
    {
        internal double length;
        internal double width;
        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length:{0}", length);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
           
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 15.5;
            r.width = 2.5;
            r.Display();
            Console.ReadLine();

        }
    }
}
