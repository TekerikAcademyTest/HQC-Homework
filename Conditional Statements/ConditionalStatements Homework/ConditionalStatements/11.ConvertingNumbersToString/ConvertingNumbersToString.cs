using System;
class ConvertingNumbersToString
{

    static string generateNumber(int number)
    {
        string str = "";
        switch (number)
        {
            case 0:
                break;
            case 1:
                str = "one";
                break;
            case 2:
                str = "two";
                break;
            case 3:
                str = "three";
                break;
            case 4:
                str = "four";
                break;
            case 5:
                str = "five";
                break;
            case 6:
                str = "six";
                break;
            case 7:
                str = "seven";
                break;
            case 8:
                str = "eight";
                break;
            case 9:
                str = "nine";
                break;
            case 10:
                str = "ten";
                break;
            case 11:
                str = "eleven";
                break;
            case 12:
                str = "twelve";
                break;
            case 13:
                str = "thrirteen";
                break;
            case 14:
                str = "fourteen";
                break;
            case 15:
                str = "fifteen";
                break;
            case 16:
                str = "sixteen";
                break;
            case 17:
                str = "seventeen";
                break;
            case 18:
                str = "eighteen";
                break;
            case 19:
                str = "nineteen";
                break;
            case 20:
                str = "twenty";
                break;
            case 30:
                str = "thirty";
                break;
            case 40:
                str = "forty";
                break;
            case 50:
                str = "fifty";
                break;
            case 60:
                str = "sixty";
                break;
            case 70:
                str = "seventy";
                break;
            case 80:
                str = "eighty";
                break;
            case 90:
                str = "ninety";
                break;
            default:
                str = "NaNaNaNaN";
                break;
        }

        return str;
    }

    static string generateString(int number)
    {
        if(number == 0)
        {
            return "Zero";
        }
        string str = "";
        int hundreds = number / 100;
        if (hundreds > 0)
        {
            str = generateNumber(hundreds) + " hundred ";
        }

        int tens = number % 100;
        if(tens == 0)
        {
            return str;
        }
        else if (tens < 20)
        {
            if (hundreds == 0)
            {
                str = generateNumber(tens);
            }
            else
            {
                str = str + "and " + generateNumber(tens);
            }
        }
        else
        {
            int units = tens % 10;
            tens = (tens / 10) * 10;
            str = str + generateNumber(tens) + " " + generateNumber(units);
        }
        return str;
    }

    static void Main(string[] args)
    {
        int number = -1;
        string inputNumber;
        do
        {
            Console.Write("number = ");
            inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out number);
        }
        while (number < 0 || number > 999);

        string str = generateString(number);
        Console.WriteLine(str);


    }

}
