using System;
using static System.Console;

class Quote
{
    public string Ticker { get; set; }
    public double Price { get; set; }
    public string Exchange { get; set; }

    public Quote(string ticker, double price) => (Ticker, Price, Exchange) = (ticker, price, null);

    public static string GetExchangeCountry(Quote q)
    {
        string exchange = q.Exchange;
        return exchange.StartsWith("BVB") ? "Romania" : "TheRest";
    }
}

static class Program
{
    static void Main()
    {
        var q = new Quote("TLV", 2.41);
        var country = Quote.GetExchangeCountry(q);
        WriteLine(country);
    }
}
