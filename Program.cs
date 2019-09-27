using static System.Console;

public class Program
{
    static void Main()
    {
        var fileName = "IDontExist.txt";
        var filePath = $@"c:\Really\Don't Look Here\{fileName}";
        WriteLine(filePath);
    }
}