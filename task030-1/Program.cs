using System;
using System.Linq;
 
class Program
{
    static void Main()
    {
        var a = Enumerable.Repeat(new Random(), 8).Select(x => x.Next(1, 11)).ToArray();
        Console.WriteLine(string.Join(", ", a));

        a = a.Select((x, i) => i % 2 == 1 ? 0 : x).ToArray();
        
        Console.WriteLine(string.Join(", ", a));
        Console.ReadKey();
    }
}
