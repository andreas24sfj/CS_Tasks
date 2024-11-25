namespace CS_Tests;

class Program
{
    static void Main(string[] args)
    {

        // Create a new instance of the Greeting class
        Greetings greetings = new Greetings();
        Fundament fundament = new Fundament();

        fundament.CheckOddOrEven(8);
        fundament.CheckOddOrEven(7);
        fundament.SumTwoNumbers();
        Console.WriteLine(fundament.SumTwoNumbersOfGivenType(8, 9));
        Console.WriteLine(fundament.GetAInterestingFact("This is an interesting fact!"));
        fundament.PrintFibonnaciSeries();
        // English greeting
        greetings.SayHello();
        // Japanese greeting
        greetings.YoiTsuitachi();
    }
}
