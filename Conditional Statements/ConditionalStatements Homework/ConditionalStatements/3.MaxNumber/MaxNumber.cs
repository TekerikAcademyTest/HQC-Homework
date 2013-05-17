using System;

class MaxNumber
{
    static void Main(string[] args)
    {
        int a, b, c;
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

        do
        {
            Console.Write("c = ");
            inputNumber = Console.ReadLine();
        }
        while (!int.TryParse(inputNumber, out c));
       // Console.WriteLine("a is {0}, b is {1}, c is {2}", a, b, c);
        int max = a;
        if (max < b)
        {
            max = b;
            if (max < c)
            {
                max = c;
            }

        }
        else if (max < c)
        {
            max = c;
        }
        Console.WriteLine("max : {0}", max);
        
    }
}
