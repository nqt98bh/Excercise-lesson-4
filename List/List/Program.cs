class List
{
    private static void Main()
    {
        //Part 1
        List<string> animals = new List<string>();
        animals.Add("Chiken");
        animals.Add("Dog");
        animals.Add("Cat");
        animals.Add("Pig");
        animals.Add("Bird");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        //Part 2
        Console.WriteLine($"3rd animal is {animals[2]}");

        //Part 3
        animals.RemoveAt(1);
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        //Part 4
        animals.Add("Tiger");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        //Part 5
        int numberOfAnimals = animals.Count;
        Console.WriteLine($"there are {numberOfAnimals} animals in this list");

        //Part 6
        bool checkName = animals.Contains("Lion");
        if (checkName == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        //Part 7
        int IndexOfAnimals = animals.IndexOf("Pig");
        Console.WriteLine(IndexOfAnimals);

        //Part 8
        animals.Insert(3, "Turtle");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        //Part 9
        animals.Sort();
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }

        //Part 10
        int lastIndex = animals.FindLastIndex(name => name == "Dog");
        Console.WriteLine(lastIndex);

        //Part 11
        animals.Clear();
        if (animals.Count == 0)
        {
            Console.WriteLine("list is empty");
        }

        //Part 12
        List<object> Properties = new List<object>();
        Properties.Add(100);
        Properties.Add("Fire");
        Properties.Add(20);
        foreach (var property in Properties)
        {
            Console.WriteLine(property);
        }

    }
}