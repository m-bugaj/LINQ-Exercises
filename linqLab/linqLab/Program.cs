using System;
using System.Linq;

class Program
{
    static void Main()
    {
// ZAD 1
        int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

        var result = from num in n1
                     where num % 2 == 0
                     select num;

        Console.WriteLine("ZAD1");

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }

        // ZAD 2
        result = from num in n1
                 where num % 2 != 0
                 select num;

        Console.WriteLine("");
        Console.WriteLine("ZAD2");

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }



    }
}
