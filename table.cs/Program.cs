 using System;

namespace table
{
    class Print
    {
        static void Main(string[] args)
        {
            int x, num;
            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine(x*num);
                Console.ReadLine();

            }
        }
    }
}
