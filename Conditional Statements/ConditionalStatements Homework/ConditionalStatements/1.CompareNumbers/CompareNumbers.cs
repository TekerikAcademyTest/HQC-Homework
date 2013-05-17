using System;

class CompareNumbers
{
    static void Main(string[] args)
    {
        int a, b;
        string inputNumber;
        do
        {
            Console.Write("a = ");
            inputNumber = Console.ReadLine();
        }
        while (!int.TryParse(inputNumber, out a));
        do
        {
            Console.Write("b = ");
            inputNumber = Console.ReadLine();
        }
        while (!int.TryParse(inputNumber, out b));
        if (a > b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        Console.WriteLine("a is {0}\nb is {1}", a, b);
    }
}