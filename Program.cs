using System;

struct Entry<K, V>
{
    public K Key;
    public V Value;
}

public class Program
{
    static void Main()
    {
        Span<Entry<int,int>> dict = stackalloc[]
        {
            new Entry<int, int> { Key = 0, Value = 0 },
            new Entry<int, int> { Key = 1, Value = 0 },
            new Entry<int, int> { Key = 2, Value = 0 },
        };

/*
        Span<Entry<int, string>> dict2 = stackalloc[]
        {
            new Entry<int, string> { Key = 0, Value = "Bob" },
            new Entry<int, string> { Key = 0, Value = "Rob" },
            new Entry<int, string> { Key = 0, Value = "Dod" },
        };
*/

    }
}
// LangVersion, strings