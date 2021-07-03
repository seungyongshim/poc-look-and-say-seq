using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Count1(new[] { 1 }, 50);

            void Count1(IEnumerable<int> m, int c)
            {
                if (c == 0)
                    return;

                var k = Count(m);

                Console.WriteLine(string.Join(" ", k));

                Count1(k, --c);
            }

            IEnumerable<int> Count(IEnumerable<int> list)
            {
                int a = -1;
                int b = 0;
                foreach (var item in list)
                {
                    if (a == -1)
                    {
                        a = item;
                    }
                    if (a == item)
                    {
                        b++;
                    }
                    if (a != item)
                    {
                        yield return a;
                        yield return b;
                        a = item;
                        b = 1;
                    }
                }

                yield return a;
                yield return b;
            }
        }
    }                                                                                                                                                                                         
}
