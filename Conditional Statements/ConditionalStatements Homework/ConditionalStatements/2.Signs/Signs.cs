using System;

class Signs
{
    static void Main(string[] args)
    {
        double a, b, c;
        string inputNumber;
        do
        {
            Console.Write("a = ");
            inputNumber = Console.ReadLine();
        }
        while (!double.TryParse(inputNumber, out a));
        do
        {
            Console.Write("b = ");
            inputNumber = Console.ReadLine();
        }
        while (!double.TryParse(inputNumber, out b));
        do
        {
            Console.Write("c = ");
            inputNumber = Console.ReadLine();
        }
        while (!double.TryParse(inputNumber, out c));

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("+");
            return;
        }
        bool isNegative = false;

        if (a < 0)
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    isNegative = true;
                }
            }
            else
            {
                if (c > 0)
                {
                    isNegative = true;
                }
            }
        }
        else
        {
            if (b < 0)
            {
                if (c > 0)
                {
                    isNegative = true;
                }
            }
            else
            {
                if (c < 0)
                {
                    isNegative = true;
                }
            }
        }

        if (isNegative)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }
       
    }
}