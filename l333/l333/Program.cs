using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l333
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("1. To fold");
            Console.WriteLine("2. To subtract");
            Console.WriteLine("3. To multiply");
            Console.WriteLine("4. To split");

           .


            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
                   
                case "2":
                    Console.WriteLine($"{a - b}");
                    break;
                case "3":
                    Console.WriteLine($"{a * b}");
                    break;
                case "4":
                   
            }
            Console.ReadKey();
        }
    }
}
