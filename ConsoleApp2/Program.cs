using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            double d, x1, x2;
            Console.Write("\n\n");
            Console.Write("Въведете 3 числа:\n");
            Console.Write("----------------------------------------");
            Console.Write("\n\n");

            Console.Write("Стойността на a е:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Стойността на b е: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Стойността на c е: ");
            c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Двата корена са равни.");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Пъревия корен е равен на: Root1= {0}\n", x1);
                Console.Write("Втория корен е равен на: Root2= {0}\n", x2);
            }
            else if (d > 0)
            {
                Console.Write("Both roots are real and diff-2\n");

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("Пъревия корен е равен на: {0}\n", x1);
                Console.Write("Втория корен е равен на: {0}\n", x2);
            }
            else
                Console.Write("Root are imeainary;\nNo Solution. \n\n");
        }
    }
}
