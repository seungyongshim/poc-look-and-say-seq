using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach(var v in Ant(1))
            {
                Console.Write(v + " ");
            }

            IEnumerable<int> Ant(int c) => Count1(new[] { 1 }, c);

            IEnumerable<int> Count1(IEnumerable<int> m, int c)
            {
                if (c == 0) return m;

                var k = Count(m);

                return Count1(k, --c);
            }

            IEnumerable<int> Count(IEnumerable<int> list)
            {
                var a = -1;
                var b = 0;
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
