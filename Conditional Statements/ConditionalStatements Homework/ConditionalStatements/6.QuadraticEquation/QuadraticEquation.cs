using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        double a, b, c;
        string inputNumber;
        do
        {
            Console.WriteLine("a = ");
            inputNumber = Console.ReadLine();
        }
        while (!double.TryParse(inputNumber, out a));

        do
        {
            Console.WriteLine("b = ");
            inputNumber = Console.ReadLine();
        }
        while (!double.TryParse(inputNumber, out b));

        do
        {
            Console.WriteLine("c = ");
            inputNumber = Console.ReadLine();
        }
        while (!double.TryParse(inputNumber, out c));
        if (a == 0)
        {
            Console.WriteLine("Not a quadtaric equation!");
            double x = -c / (double)b;
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            double discriminant = b*b - 4*a*c;
            if (discriminant < 0)
            {
                Console.WriteLine("No real roots!");
            }
            else if (discriminant == 0)
            {
                double x = (-b) / (2.0 * a);
                Console.WriteLine("One real root: {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2.0 * a);
                Console.WriteLine("Two real roots: {0} and {1}", x1, x2);
                
            }
        }
    }
}
