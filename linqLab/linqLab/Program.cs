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

        // ZAD 3
        var arr1 = new[] { 3, -1, -3, 6, 9, 2, -7, 0, 8, 14, 13, 24, 12, 6, 5 };

        result = from num in arr1
                 where num > 0 && num < 12
                 select num;

        Console.WriteLine("");
        Console.WriteLine("ZAD3");

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }

        // ZAD 4
        result = from num in arr1
                 where num * num > 20
                 select num;

        Console.WriteLine("");
        Console.WriteLine("ZAD4");

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }

        // ZAD 5
        int[] arr2 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

        var result5 = arr2
            .GroupBy(num => num)
            .Select(group => new { Number = group.Key, Frequency = group.Count() });

        Console.WriteLine("");
        Console.WriteLine("ZAD5");

        foreach (var num in result5)
        {
            Console.WriteLine(num);
        }

    }
}
