public class Fundament : IFundament
{
    public void CheckOddOrEven(double a)
    {
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a} is Even.");
        } else
        {
            Console.WriteLine($"{a} is Odd.");
        }
    }


    public void SumTwoNumbers()
    {
        int a = 8;
        double b = 1919;
        Console.WriteLine(a+b);
    }

    public double SumTwoNumbersOfGivenType(double a, double b)
    {
        return a + b;
    }

    public string GetAInterestingFact(string fact)
    {
        return fact;
    }

    // Extra challenges

    public void PrintFibonnaciSeries()
    {
        // How many fibonacci numbers would you like to check for?
        int count = 10;

        // Setting the first 2 numbers
        int a = 0;
        int b = 1;

        Console.WriteLine("Here is the fibonacci sequence:");
        Console.WriteLine(a);
        Console.WriteLine(b);
        //going through a for loop, incrementing once every time up to count
        for (int i = 2; i <= count; i++)
        {
            //calculate the next number in the sequence
            int c = a + b;
            Console.WriteLine(c);
            //setting the new value of a and b
            a = b;
            b = c;
        }

        /* 
        c = a + b
        a = b
        b = c
        */
    }

    public string ReverseString(string str)
    { 
        // TODO: reverse the given string
        //converting the string to an array charArray of type char
        char[] charArray = str.ToArray();
        //using the array Reverse method on the array to reverse it
        Array.Reverse(charArray);
        //making a new string with the reversed array
        string revStr = new string(charArray);
        //returning the reversed string
        return revStr;
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        // 0! & 1! == 1
        if (n == 0 || n == 1)
        {
            return 1;
        }
        // n! = n*(n-1)*...*1 // for n = 4, 4! = 4 * (4-1)!
        return n * RecursiveFactorial(n - 1);
    }

    


}
