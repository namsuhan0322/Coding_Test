using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is even", a);    
        }
        else
        {
            Console.WriteLine($"{a} is odd", a);
        }
    }
}