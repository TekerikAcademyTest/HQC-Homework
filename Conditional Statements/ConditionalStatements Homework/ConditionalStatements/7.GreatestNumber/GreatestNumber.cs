using System;

class GreatestNumber
{
    static void Main(string[] args)
    {
        double number;
        string inputNumber;
        do
        {
            Console.Write("number = ");
            inputNumber = Console.ReadLine();
        }
        while (!double.TryParse(inputNumber, out number));

        double max = number;

        int numberCount = 4;
        for (int i = 1; i < numberCount; i++)
        {
            do
            {
                Console.Write("number = ");
                inputNumber = Console.ReadLine();
            }
            while (!double.TryParse(inputNumber, out number));
            if(number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("max is {0} ", max);
    }
}