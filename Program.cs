using static System.Console;


static class Program
{
    static string[] tickers = new string[]
    {
                            // index from start    index from end
            "0-FP",         // 0                   ^9
            "1-TLV",        // 1                   ^8
            "2-SNP",        // 2                   ^7
            "3-SNG",        // 3                   ^6
            "4-BRD",        // 4                   ^5
            "5-TGN",        // 5                   ^4
            "6-EL",         // 6                   ^3
            "7-DIG",        // 7                   ^2
            "8-TEL"         // 8                   ^1
    };

    static void Main()
    {
        var sel = tickers[..4];
        foreach (var t in sel) WriteLine($"{t} ");
    }
    // -1, -2 .. 0, -2 .., .. , ..4, 6.., index, range, esoteric

}
