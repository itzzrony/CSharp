internal class Program
{
    private static void Main(string[] args)
    {
        string ok = "Hello World"; // we put the helloworld message on a variable
        Console.WriteLine(ok); // we just called out variable call in here, it will print our message which was stored on ok variable 

        Console.WriteLine(ok.Length);  // methode for do a specific task for getting length of out ok variable value
        Console.WriteLine(ok.ToUpper); // methode for higher value for our string variable
        Console.WriteLine(ok.ToLower); // methode for higher value for our string variable
        Console.WriteLine(ok.Contains("Academy")); // methode with parameter to know that this kind of information our variable have or not, that will output via true or false.
        Console.WriteLine(ok[0]); // this methode for that out variable 0 position which value have
        Console.WriteLine(ok.IndexOf("World")); // we can see the this kind of information started on which number
        Console.WriteLine(ok.Substring(5)); // this methode for where our value starting from this position and after all the information it will output 
        Console.WriteLine(ok.Substring(5, 3)); // this methode for where our value started on this position and send 3 values for us.

        Console.ReadLine(); // for holding the console for see the output
    }
}
