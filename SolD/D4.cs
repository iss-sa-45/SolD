using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolD
{
    class D4
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            double g = random.NextDouble() * (n - 1) + 1;

            while (Math.Abs(g * g - n) > 0.00001)
            {
                g = (g + n / g) / 2;
            }

            Console.WriteLine(g);
        }
    }
}
