using System;
using static System.Console;

struct Bond
{
    public double FaceValue { get; set; }
    public double Interest { get; set; }
    public DateTime Maturity { get; set; }
    public double SecretValue => Math.Sqrt(FaceValue * Interest);

    public Bond(double faceValue, double interest, DateTime maturity) =>
        (FaceValue, Interest, Maturity) = (faceValue, interest, maturity);

    public override string ToString() => $"SecretValue: {SecretValue}";

    public void SetValues(double face, double interest) => (FaceValue, Interest) = (face, interest);
}

class Program
{
    static void Main()
    {
        var b = new Bond() { FaceValue = 1_000, Interest = 0.05, Maturity = DateTime.Now.AddMonths(12) };
        WriteLine(b);
    }
}

// ro on tostring, fix, setvalues
