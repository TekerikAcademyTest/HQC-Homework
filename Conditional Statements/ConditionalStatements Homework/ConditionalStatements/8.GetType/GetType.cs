using System;

class GetType
{
    static void Main(string[] args)
    {
        Console.Write("input here: ");
        string input = Console.ReadLine();
       
        int intNum = 0;
        double doubleNum = 0.0;
        string type = input.GetType().ToString();
        
        if(Int32.TryParse(input, out intNum))
        {
            intNum = intNum + 1;
            type = intNum.GetType().ToString();
        }
        else if(Double.TryParse(input, out doubleNum))
        {
            doubleNum = doubleNum + 1.0;
            type = doubleNum.GetType().ToString();
        }
        else 
        {
            input = input + "*";
        }
       

        switch (type)
        {
            case "System.Int32":
                Console.WriteLine(intNum);
                break;
            case "System.Double":
                Console.WriteLine(doubleNum);
                break;
            case "System.String":
                Console.WriteLine(input);
                break;
            default:
                Console.WriteLine("NaNaNaN");
                break;

        }
        
    }
}
