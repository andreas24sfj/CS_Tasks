namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {

        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        Fundament fundament = new Fundament();

        //CHECK IF SPECIFIED NUMBER IS ODD OR EVEN
        fundament.CheckOddOrEven(8);
        fundament.CheckOddOrEven(7);

        //SUM OF TWO NUMBERS. int a = 9, double b = 100
        fundament.SumTwoNumbers();

        //SUM OF TWO NUMBERS DOUBLE
        Console.WriteLine(fundament.SumTwoNumbersOfGivenType(8, 9));

        //WRITES "This is an interesting fact!" in console
        Console.WriteLine(fundament.GetAInterestingFact("This is an interesting fact!"));

        //FIBONACCI SEQUENCE FOR SPECIFIED COUNT
        fundament.PrintFibonnaciSeries(5);

        //REVERSE A STRING
        Console.WriteLine("This is the sentence that is to be reversed.");
        Console.WriteLine(fundament.ReverseString("This is the sentence that is to be reversed."));

        //FIND FACTORIAL OF NUMBER N
        Console.WriteLine("This is the factorial: " + fundament.RecursiveFactorial(4));

        
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();
    }
}
