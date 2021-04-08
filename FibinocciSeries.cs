using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Fibinocci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum = 0;
            for(int i=2;i<=n;i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;

            }
            return n == 0 ? n1 : n2;

        }
        static void Main(string[] args)
        {
            int result = Fibinocci(7);
            Console.WriteLine(result);
        }
    }
}
