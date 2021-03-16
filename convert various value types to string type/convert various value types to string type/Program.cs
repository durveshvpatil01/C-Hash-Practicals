using System;
namespace convert_various_value_types_to_string_type
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 15;
            float f = 2002.005f;
            double d = 20021.7652;
            bool b = true;
            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
