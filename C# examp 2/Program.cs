using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__examp_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            int x;
            int r;
            int sum = 0;
            int temp;

            Console.WriteLine("Enter a number");
            x=int.Parse(Console.ReadLine());
            temp = x;

            while (x > 0)
            {
                r = x % 10;
                sum = (sum * 10) + r;
                x = x / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }

            //freeze console
            Console.ReadLine();

        }
    }
}
