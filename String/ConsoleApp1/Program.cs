using System.ComponentModel;
using System.Linq;
using System.Reflection;




class String
{
    static void Main()
    {
        //Part 1
        string firstName = "    Nguyen";
        string middleName = "Quyet";
        string lasrname = "Thang    ";
        string fullName = ($"{firstName} {middleName} {lasrname}").ToUpper();
        Console.WriteLine(fullName);

        //Part 2
        string FullName = fullName.ToLower();
        Console.WriteLine(FullName);

        //Part 3
        int lengthOfName = FullName.Length;
        Console.WriteLine($"the length of name is {lengthOfName} ");

        //Part 4
        int indexOfCharacter = FullName.IndexOf("thang");
        Console.WriteLine($"part 4: {indexOfCharacter}");

        //Part 5
        int indexOfSpecificChar = FullName.IndexOf("u", 6);
        Console.WriteLine(indexOfSpecificChar);

        //Part 6
        char CharNeedToFind = 'g';
        int count = FullName.Count(c => c == CharNeedToFind);
        Console.WriteLine(count);

        //Part 7
        string FirstnameChange = firstName.Replace('u', 'y');
        Console.WriteLine(FirstnameChange);

        //Part 8
        int IndexOfCharacter = firstName.IndexOf('g');
        string charRemoved = firstName.Remove(IndexOfCharacter, IndexOfCharacter);
        Console.WriteLine(charRemoved);

        //Part 9
        string charReplaced = FullName.Replace('n', 't');
        Console.WriteLine(charReplaced);

        //Part 10
        string substringName = fullName.Substring(0, 10);
        Console.WriteLine(substringName);

        //Part 11
        string substringName1 = fullName.Substring(10);
        Console.WriteLine(substringName1);

        //Part 12
        string removeSpace = fullName.Trim();
        Console.WriteLine(removeSpace);

        //Part13
        string numberInString = "123456"; // can not parse letters
        int parseToInt = int.Parse(numberInString);
        Console.WriteLine(parseToInt);

        //Part 14
        string convertToString = parseToInt.ToString();
        Console.WriteLine(convertToString);



    }
}



