using System;
using static System.Console;

internal ref struct InterestMatrix
{
    private string name;
    private bool beenDisposed;

    public InterestMatrix(string name, bool beenDisposed = false) => (this.name, this.beenDisposed) = (name, beenDisposed);

    public void Dispose()
    {
        beenDisposed = true;
        Console.WriteLine($"Disposing {name}");
    }

    internal void CopyFrom(InterestMatrix src)
    {
        switch (beenDisposed, src.beenDisposed)
        {
            case (false, false): Console.WriteLine($"Copying from {src.name} to {name}"); return;
            case (_, _): throw new ObjectDisposedException($"Resource {name} has already been disposed");
        };

    }
}
public class Program
{
    static void Main()
    {
        using (var src = new InterestMatrix("source"))
        {
            using (var dest = new InterestMatrix("destination"))
            {
                dest.CopyFrom(src);
            }
        }
    }
}
