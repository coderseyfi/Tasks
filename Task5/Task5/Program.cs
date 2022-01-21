using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-50 arasi ancaq 5-e ya da 3-e bolunen ededler");
            Console.WriteLine("----------------------------------------------");
            for (int i=1;  i<50; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
