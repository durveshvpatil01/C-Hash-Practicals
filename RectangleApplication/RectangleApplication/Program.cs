using System;

namespace RectangleApplication
{
    class Rectangle
    {

        // member variables
        Double length;
        Double width;

        public void Acceptdetails()
        {
            length = 15.5;
            width = 19.5;
        }
        public double GetArea()
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
        static void Main(string[]
        args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}