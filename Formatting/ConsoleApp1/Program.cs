class Formatting
{
    static void Main()
    {
        Part1();
        Part2();
        Part3();
        Part4();
        Part5();
        Part6();
        Part7();
        Part8();
        Part10();
        Part11();
        Part12();
        Part13();
        Part14();
        Part15();

    }
    static void Part1()
    {
        string recipientName = "Alice";
        DateTime eventDate = new DateTime(2025, 1, 15, 09, 00, 0);
        Console.WriteLine("Hello, {0}! You're invited to our team outing on {1}. " +
            "The event starts at {2}.", recipientName, eventDate.ToString("MMMM dd, yyyy"), eventDate.ToString("hh:mm tt"));
    }
    static void Part2()
    {
        string customerName = "John Doe";
        string orderID = "123456";
        string purchaseDetail = "2 x T-shirts, 3 x Jeans";
        Console.WriteLine("Dear {0}, your order({1}) has been confirmed." +
            "You've purchased: {2}.", customerName, orderID, purchaseDetail);
    }

    static void Part3()
    {

        string taskName = "Complete Project Proposal";
        DateTime dueDate = new DateTime(2025, 3, 10);
        string priorityLevel = "High";
        Console.WriteLine("{0} is due on {1}. Priority: {2}.", taskName, dueDate.ToString("MMMM dd, yyyy"), priorityLevel);
    }

    static void Part4()
    {
        string eventTitle = "Team Meeting";
        string location = "Conference Room A";
        DateTime startTime = new DateTime(1, 1, 1, 10, 00, 0);
        Console.WriteLine("{0} at {1} starts at {2}", eventTitle, location, startTime.ToString("hh:mm tt"));
    }
    static void Part5()
    {
        string flightNumber = "ABC123";
        string departureAirport = "JFK International Airport";
        DateTime scheduledTime = new DateTime(1, 1, 1, 08, 00, 0);
        Console.WriteLine("Flight {0} departing from {1} is scheduled for {2}", flightNumber, departureAirport, scheduledTime.ToString("hh:mm tt"));
    }

    static void Part6()
    {
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Welcome to our messaging app");
    }

    static void Part7()
    {
        string characterName = Console.ReadLine();
        string characterClass = Console.ReadLine();
        Console.WriteLine($"{characterName} the {characterClass}");
    }

    static void Part8()
    {
        int songDuration = int.Parse(Console.ReadLine());
        int songInSecond = songDuration % 60;
        int songInMinute = songDuration / 60;
        Console.WriteLine($"{songInMinute} minutes {songInSecond} second");
    }

    static void Part9()
    {
        string numberOfsize = Console.ReadLine();
        Console.WriteLine("Serving Size: {0,5}", numberOfsize);
    }

    static void Part10()
    {
        decimal accountBalance = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"Account Balance:  {accountBalance}");

    }

    static void Part11()
    {
        decimal tickerPrice = decimal.Parse(Console.ReadLine());
        decimal discountPercentage = decimal.Parse(Console.ReadLine());
        decimal discountPrice = tickerPrice * (1 - discountPercentage / 100);
        Console.WriteLine($"Discounted Price: {discountPrice:F2}");
    }

    static void Part12()
    {
        int playerScore = int.Parse(Console.ReadLine());
        Console.WriteLine($"Player's Score:{playerScore,8}");
    }

    static void Part13()
    {
        string seriesOfNumber = Console.ReadLine();
        string[] numbers = seriesOfNumber.Split(' '); //split a string into sepaeated numbers by spaces
        int[] parseNumbers = Array.ConvertAll(numbers, int.Parse); //convert all string numbers to array of integer numbers
        double average = parseNumbers.Average();
        Console.WriteLine($"Average Value: {average:F2} ");
    }

    static void Part14()
    {
        string enterTempuratures = Console.ReadLine();
        string[] tempuratures = enterTempuratures.Split(' ');
        decimal[] parseTempuratures = Array.ConvertAll(tempuratures, decimal.Parse);
        decimal averageTem = parseTempuratures.Average();
        Console.WriteLine($"Average Tempurature: {averageTem:F1}");
    }

    static void Part15()
    {
        string stepTaken = Console.ReadLine();
        Console.WriteLine($"Step Count: {stepTaken,6}");
    }
}
