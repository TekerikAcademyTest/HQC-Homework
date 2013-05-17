using System;

class Sort
{
    static void Main(string[] args)
    {
        int a, b, c;
        string inputNumber;
        do
        {
            Console.WriteLine("a = ");
            inputNumber = Console.ReadLine();
        }
        while (!int.TryParse(inputNumber, out a));

        do
        {
            Console.WriteLine("b = ");
            inputNumber = Console.ReadLine();
        }
        while (!int.TryParse(inputNumber, out b));

        do
        {
            Console.WriteLine("c = ");
            inputNumber = Console.ReadLine();
        }
        while (!int.TryParse(inputNumber, out c));

        int min = a, max = a, middle = a;

        if (min > b)
        {
            min = b;
            if (min < c)
            {
                min = c;
            }
        }
        else if (min > c)
        {
            min = c;
        }

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

        Console.WriteLine("{0}, {1}, {2}", min, middle, max);
    }
}
