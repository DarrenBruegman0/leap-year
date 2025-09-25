// See https://aka.ms/new-console-template for more information

//main loop
using System.Reflection.PortableExecutable;

while (true)
{
    bool even = false;
    bool by4 = false;
    bool by100 = false;
    bool by400 = false;
    Console.Write("what year?   ");
    int x = Convert.ToInt32(Console.ReadLine());
    //determines the divisibility
    if (x % 2 == 0)
    {
        even = true;
    }
    if (x % 4 == 0)
    {
        by4 = true;
    }
    if (x % 100 == 0)
    {
        by100 = true;
    }
    if (x % 400 == 0)
    {
        by400 = true;
    }
    //determines if x is a leap year
    if (even)
    {
        if (by4 && by4 != by100 || (by400 == by100 && by100 == true))
        {
            Console.WriteLine($"The Year {x} is a leap year");
        }
        else
        {
            Console.WriteLine($"The Year {x} isn't a Leap Year");
        }
    }
    else
    {
        Console.WriteLine($"The Year {x} isn't a Leap Year");
    }
    //displays each result from divisibility test
    Console.WriteLine($"divisible by 2:   {even}");
    Console.WriteLine($"divisible by 4:   {by4}");
    Console.WriteLine($"divisible by 100: {by100}");
    Console.WriteLine($"divisible by 400: {by400}");
}