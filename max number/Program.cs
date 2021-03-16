using System;
namespace max_number
{
    class Program
    {
        public int FindMax(int num1,int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }   
        static void Main(string[] args)
        {
            int a = 451;
            int b = 857;
            int ret;
            Program n = new Program();
            ret = n.FindMax(a, b);
            Console.WriteLine("Max value is:{0}", ret);
            Console.ReadLine();
        }
    }
}