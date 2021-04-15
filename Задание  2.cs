using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            private static ISet<string> Compute(int n)
            {
                var set = new HashSet<string>();

                for (int i = 2; i < n; i++)
                    set.Add(ToBinaryString(i));

                for (int step = 2; step < n; step++)
                    for (int i = 2 * step; i < n; i += step)
                        set.Remove(ToBinaryString(i));

                return set;
            }

            private static string ToBinaryString(int x)
            {
                return x == 0 ? "0" : ToBinaryString(x / 2) + x % 2;
            }
        }
    }
}
