using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 16, 17, 15, 0, 20, 1, 1, 2 };
        int n = arr.Length;
        int max_load = 0, load = 0, diff = 0;

        load = arr.Sum();
        load /= -n;

        for (int i = 0; i < n; i++)
        {
            diff += arr[i] - load;
            if (diff < 0)
            {
                max_load = Math.Max(max_load, -diff);
            }
            else
            {
                max_load = Math.Max(max_load, diff);
            }
        }

        Console.WriteLine(max_load);
    }
}