using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett räknessätt. ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. division");

            int sätt = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj talen");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());

            switch (sätt)
            {
                case 1:
                    Console.WriteLine(tal1 + tal2);
                    break;
                case 2:
                    Console.WriteLine(tal1 - tal2);
                    break;
                case 3:
                    Console.WriteLine(tal1 * tal2);
                    break;
                case 4:
                    Console.WriteLine(tal1 / tal2);
                    break;
            }



        }
    }
}
