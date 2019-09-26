using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

class Quote
{
    public string Ticker { get; set; }
    public double Price { get; set; }
    public string Exchange { get; set; }

    public Quote(string ticker, double price) => (Ticker, Price, Exchange) = (ticker, price, null);
}

static class Program
{
    internal static async IAsyncEnumerable<double> GenerateQuotes()
    {
        var quotes = Enumerable.Repeat(new Quote("BVB", 2.41), 20);

        var i = 0;
        foreach (var q in quotes)
        {
            // every 3 elements, wait 2 seconds:
            if (i % 3 == 0)
                await Task.Delay(2000);
            i++;
            yield return q.Price;
        }
    }

    public static async Task Main()
    {
        await foreach (var price in GenerateQuotes())
        {
            WriteLine($"The time is {DateTime.Now:hh:mm:ss}. Retrieved {price}");
        }
    }
}
