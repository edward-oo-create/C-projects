using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Edward",
            "John",
            "Sarah"
        };

        // Add an item
        names.Add("Mike");

        // Access an item
        Console.WriteLine(names[0]);

        // Remove an item
        names.Remove("John");

        // Loop through the list
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Number of items
        Console.WriteLine($"Count: {names.Count}");
    }
}