using System;

class SumOfSubset
{    
    static void Main(string[] args)
    {
        int numbersCount = 5;
        int[] numbers = new int[numbersCount];
        string inputNumber;
        for (int i = 0; i < numbersCount; i++)
        {
            do
            {
                Console.Write("insert number: ");
                inputNumber = Console.ReadLine();
            }
            while (!int.TryParse(inputNumber, out numbers[i]));
        }
        bool zeroSum = SubsetSum(numbers, numbersCount);
        Console.WriteLine(zeroSum);
        
    }

    static bool SubsetSum(int[] numbers, int length)
    {
        int sum = 0;
        int coef;
        int numberOfSubsets = (int)(Math.Pow(2, length) - 1);
        for (int i = 1; i <= numberOfSubsets; i++)
        {
            sum = 0;
            for (int j = 0; j < length; j++)
            {
                coef = i >> j;
                coef = coef & 1;
                sum = sum + coef * numbers[j];
            }
            if (sum == 0)
            {
                return true;
            }
        }
        return false;
    }
}
