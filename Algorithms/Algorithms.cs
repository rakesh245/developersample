using System;
using System.Text;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            var result = 1;
            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
            }
            return result;
        }

        public static string FormatSeparators(params string[] items)
        {
            if (items != null && items.Length > 0)
            {
                var counter = 1;
                var result = new StringBuilder();
                var paramLength = items.Length;
                foreach (var item in items)
                {
                    if (counter == paramLength)
                        result.AppendFormat("and {0}", item);
                    else if (counter == paramLength - 1)
                        result.AppendFormat("{0} ", item);
                    else
                        result.AppendFormat("{0}, ", item);
                    counter++;
                }
                return result.ToString();
            }
            return null;
        }
    }
}