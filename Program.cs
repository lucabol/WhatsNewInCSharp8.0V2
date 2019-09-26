using static System.Console;

internal ref struct InterestMatrix
{
    private string name;

    public InterestMatrix(string name) => this.name = name;

    public void Dispose() => WriteLine($"Disposing {name}");

    internal void CopyFrom(InterestMatrix src) => WriteLine($"Copying {src.name} to {name}");
}
public class Program
{
    static void Main()
    {
        using (var src = new InterestMatrix("src-matrix"))
        {
            using (var dest = new InterestMatrix("dst-matrix"))
            {
                dest.CopyFrom(src);
            }
        }
    }
}
