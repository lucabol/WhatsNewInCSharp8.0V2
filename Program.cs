using System;
using System.Collections.Generic;
using static System.Console;

class Program
{
    static void Main()
    {
        foreach (var i in DiscountTable(1, 10)) WriteLine(i);
    }

    public static IEnumerable<double> DiscountTable(int start, int end)
    {
        // Do other interesting stuff ...

        return generateSequence();

        IEnumerable<double> generateSequence()
        {
            for (int i = start; i < end; i++)
                yield return i/10.0;
        }
    }
}
