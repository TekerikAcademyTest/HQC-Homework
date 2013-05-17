using System;

class BonusScores
{
    static void Main(string[] args)
    {
        char digit = (char)Console.Read();
        int num;
        bool error = false;
        int.TryParse(digit.ToString(), out num);

        switch (digit)
        {
            case '1':
            case '2':
            case '3':
                num = num * 10;
                break;
            case '4':
            case '5':
            case '6':
                num = num * 100;
                break;
            case '7':
            case '8':
            case '9':
                num = num * 1000;
                break;
            default:
                error = true;
                break;
        }

        if (error)
        {
            Console.WriteLine("ERROR!");
        }
        else
        {
            Console.WriteLine(num);
        }
        
    }
}
