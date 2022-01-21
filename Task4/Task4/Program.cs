using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1 - 50]'e butun tek ededler:");
            Console.WriteLine("------------------");
           for (int i=0; i<= 50; i++)

            {
                if (i%2 != 0)
                {
                    
                    Console.WriteLine(i);
                }

            }
        }
    }
}
