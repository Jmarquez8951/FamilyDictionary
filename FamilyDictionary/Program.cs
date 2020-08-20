using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main()
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("Brother", new Dictionary<string, string>() { { "name", "Alex" }, { "age", "27" } });
            myFamily.Add("Dad", new Dictionary<string, string>() { { "name", "Jose" }, { "age", "51" } });
            myFamily.Add("Mom", new Dictionary<string, string>() { { "name", "Lupe" }, { "age", "50" } });

            foreach (var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and they are {member.Value["age"]}.");
            }
        }
    }
}
