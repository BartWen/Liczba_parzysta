using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczba_parzysta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj cyfre");

            var userNumber = GetUsernumber();

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Podana cyfra jest parzysta");
            }
            else { Console.WriteLine("Podana cyfra jest nieparzysta"); }
        }

        private static int GetUsernumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("Podaj poprawną wartość");
                    continue;
                }
                return number;
            }
           
        }
    }
}
