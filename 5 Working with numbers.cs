internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(5 + 8); 
        Console.WriteLine(5 - 8);
        Console.WriteLine(5 * 8);
        Console.WriteLine(5 / 8);
        Console.WriteLine(5 % 8); // all of these done basic math operation in the direct console outpur, we don't need to put the variable in var for that
        Console.WriteLine(5 + 8 * 2); // in here the multiplication will hapen first cause this is the basic rules of the programming
        Console.WriteLine((5 + 8) * 2); // for working the summation first we can use parameters for that we can specify which will be done
        Console.WriteLine(5 + 8.1);
        Console.WriteLine(5 / 8.5); // the double value will work fine in the direct console

        int var = 8; // we put a value in the variable
        var++; // by these methode we can increase the variable value.. the value will increase one on this methode
        Console.WriteLine(var); // printing value
        var--; // by these methode we can decrease the variable value.. the value will decrease one on this methode
        Console.WriteLine(var);

        Console.WriteLine(Math.Abs(-40)); // by methode math we can do some advance math operation by these.. here we put the absolute value of negative forty
        Console.WriteLine(Math.Pow(5, 3)); // power will hapen 3 by 2 times
        Console.WriteLine(Math.Sqrt(9)); // squreroote of 9
        Console.WriteLine(Math.Max(4, 50)); // for max value betweeen two values
        Console.WriteLine(Math.Min(4, 50)); // for min value betweeen two values
        Console.WriteLine(Math.Round(4.90)); // for the round value of a point number


        Console.ReadLine(); // for holding the console for see the output
    }
}
