using System;
using static System.Console;

readonly struct Stock
{
    public readonly string Ticker;
    public readonly double Price;

    public Stock(string ticker, double price) => (Ticker, Price) = (ticker, price);
}

readonly struct Bond
{
    public readonly double FaceValue;
    public readonly double Interest;
    public readonly DateTime Maturity;

    public Bond(double faceValue, double interest, DateTime maturity) =>
        (FaceValue, Interest, Maturity) = (faceValue, interest, maturity);
}

static class Calculator
{
    static double CalcPrice(object contract)
    {
        double price;
        switch(contract)
        {
            case Stock s:
                price = s.Price;
                break;
            case Bond b:
                price = b.FaceValue;
                break;
            case null:
                throw new Exception("Contract can't be null.");
            default:
                throw new Exception("Not a known contract type.");
        };
        return price;
    }
    static void Main()
    {
        var s = new Stock("BVP", 2.41);
        var b = new Bond(1_000, 0.05, DateTime.Now.AddMonths(12));

        WriteLine(Calculator.CalcPrice(s));
        WriteLine(Calculator.CalcPrice(b));

    }
}
// Expr, prop var, tuple combin, recur, deconstruct?
