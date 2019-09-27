using static System.Console;

public readonly struct Bond
{
    public readonly double FaceValue;
    public readonly double Interest;
    public Bond(double f, double i) => (FaceValue, Interest) = (f, i);
}

interface IPricer
{
    double Price(Bond b);
}

class StandardPricer : IPricer
{
    double IPricer.Price(Bond b) => b.FaceValue * b.Interest / 0.1;
}

class OptimizedPricer : IPricer
{
    double IPricer.Price(Bond b) => (b.FaceValue * b.Interest / 0.1) * 2;
}

// ... Several other Pricers ...

public class Program
{
    static void Main()
    {
        var b = new Bond(1_000, 0.05);

        IPricer st = new StandardPricer();
        WriteLine(st.Price(b));

        st = new OptimizedPricer();
        WriteLine(st.Price(b));
    }
}