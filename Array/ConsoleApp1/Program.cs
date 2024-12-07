class Array
{
    private static void Main()
    {
        //Part 1
        string[] Countries = new string[5] { "France", "Germany", "England", "Italy", "Japan" };
        for (int i = 0; i < Countries.Length; i++)
        {
            Console.WriteLine(Countries[i]);
        }
        foreach (string Country in Countries)
        {
            Console.WriteLine(Country);
        }

        //Part 2
        Console.WriteLine($"3rd country is {Countries[2]}");

        //Part 3
        RemoveAt(2);
        void RemoveAt(int index)
        {
            if (index >= 0 && index < Countries.Length)
            {
                string[] newArray = new string[Countries.Length - 1];

                for (int i = 0, j = 0; i < Countries.Length; i++)
                {
                    if (i != index) // Skip the element at the specified index
                    {
                        newArray[j] = Countries[i];
                        j++;
                    }
                }
                Countries = newArray;
            }
        }
        foreach (string Country in Countries)
        {
            Console.WriteLine(Country);
        }

        //Part 4
        Countries[3] = "Spain";
        foreach (string Country in Countries)
        {
            Console.WriteLine(Country);
        }

        //Part 5
        int LengthOfCountries = Countries.Length;
        Console.WriteLine($"there are {LengthOfCountries} countries in this array");

        //Part 6
        bool checkName = Countries.Contains("France");
        if (checkName == true)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        //Part 7
        int index = System.Array.IndexOf(Countries, "Germany");
        Console.WriteLine($"the index of Germany is {index}");

    }
}
