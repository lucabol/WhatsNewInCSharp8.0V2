using System;
using System.Collections.Generic;
using static System.Console;

public class Program
{
    static Random rnd = new Random();

    static List<double> GetPrices() => rnd.NextDouble() > 0.5 ? null : new List<double>();

    static void Main()
    {

        var prices = GetPrices();
        prices ??= new List<double>();

        int? i = null;
        prices.Add(i ??= 17);
        prices.Add(i ??= 20);

        WriteLine(string.Join(' ', prices));
        WriteLine(i);
    }
}
// Equivalence