using System;

{
    static void Main()
    {
        string userInput = "";
        Random rnd = new Random();
        int investice = rnd.Next(1, 100);

        Console.WriteLine("1. Bitcoin ");
        Console.WriteLine("2. Ethereum ");
        Console.WriteLine("3. Dogecoin ");

        Console.Write("Do ceho chcete investovat? ");
        userInput = Console.ReadLine();

        if (userInput != "Bitcoin")
        {
            if (investice <= 15)
            {
                Console.WriteLine("Investice nevysla");
            }
        }
        else if (userInput != "Ethereum")
        {

        }
    }
}
