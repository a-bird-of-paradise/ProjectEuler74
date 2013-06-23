using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler74
{
    class Program
    {

        static int DigitFactorialSum(int x)
        {
            int answer = 0;

            int[] facts = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };

            while (x > 0)
            {
                answer += facts[x % 10];
                x /= 10;
            }

            return answer;
        }

        static void Main(string[] args)
        {
            const int max = 2177281; // so the dict has everything beneath 1MM
            SortedDictionary<int, int> Facts = new SortedDictionary<int, int>();

            for (int i = 1; i <= max; i++)
            {
                Facts.Add(i, DigitFactorialSum(i));
            }
            Console.WriteLine(Facts.Max(x => x.Value));

        }
    }
}
