// Program.cs
using System;
using System.Collections.Generic;

namespace CollectionsAndLoops_25
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Loops & Collections – Practice ===\n");

            // =====================================================================
            // Assignment 1: Collect numbers to list
            // Goal: Use a for-loop to read N integers and store them in List<int>.
            // Also print the list with a foreach-loop.
            // =====================================================================
            const int listCount = 5;
            Console.WriteLine($"[LIST] Enter {listCount} numbers:");
            List<int> numbers = Assignments.CollectNumbersToList(listCount);
            Console.WriteLine("\nThe numbers you entered are:");
            Assignments.PrintList(numbers);

            // =====================================================================
            // Assignment 2: Calculate average, find min and max
            // Goal: Implement algorithms without LINQ's Average/Min/Max.
            // =====================================================================
            double avg = Assignments.CalculateAverage(numbers);
            int min;
            int max;
            Assignments.FindMinAndMax(numbers, out min, out max);
            Console.WriteLine($"\nAverage of the numbers: {avg}");
            Console.WriteLine($"Largest number: {max}");
            Console.WriteLine($"Smallest number: {min}");

            // =====================================================================
            // Assignment 3: Filter values above a threshold
            // Goal: Ask a threshold and build a new list of values > threshold.
            // =====================================================================
            int threshold = Assignments.ReadInt("Enter a threshold value: ");
            List<int> aboveThreshold = Assignments.FindAboveThreshold(numbers, threshold);
            Console.WriteLine("Numbers greater than the threshold:");
            if (aboveThreshold.Count == 0)
            {
                Console.WriteLine("(None)");
            }
            else
            {
                Assignments.PrintList(aboveThreshold);
            }

            // =====================================================================
            // Assignment 4: Remove numbers from the list (repeatable)
            // Goal: Use List.Remove and handle the case where the number is not found.
            // =====================================================================
            while (true)
            {
                Console.Write("\nEnter a number to remove from the list: ");
                int toRemove = Assignments.ReadInt(null);
                Assignments.RemoveNumberFromList(numbers, toRemove);

                Console.WriteLine("\nUpdated list:");
                Assignments.PrintList(numbers);

                Console.Write("Do you want to remove another number? (y/n): ");
                string ans = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
                if (ans != "y") break;
            }

            // =====================================================================
            // Assignment 5: Add random numbers to the list
            // Goal: Demonstrate Random and appending values to the List<int>.
            // =====================================================================
            Console.Write("\nAdd random numbers (1–100) to the list? (y/n): ");
            string addRandomAnswer = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
            if (addRandomAnswer == "y")
            {
                int count = Math.Max(0, Assignments.ReadInt("How many random numbers to add?: "));
                Assignments.AddRandomNumbers(numbers, count, 1, 100);
                Console.WriteLine("List after adding random numbers:");
                Assignments.PrintList(numbers);
            }

            // =====================================================================
            // Assignment 6: Collect (name, score) pairs to Dictionary<string,int>
            // Goal: Use a for-loop to fill a dictionary; avoid duplicate keys.
            // =====================================================================
            const int dictCount = 3;
            Console.WriteLine($"\n[DICTIONARY] Enter {dictCount} names and ages:");
            Dictionary<string, int> persons = Assignments.CollectDataToDictionary(dictCount);

            // =====================================================================
            // Assignment 7: Print dictionary with foreach
            // Goal: Iterate KeyValuePair<string,int> and display entries.
            // =====================================================================
            Console.WriteLine("\nEntered data:");
            Assignments.PrintDictionary(persons);

            // =====================================================================
            // Assignment 8: Find a value by key
            // Goal: Ask for a key (name) and print the value if it exists.
            // =====================================================================
            Console.Write("\nEnter a name to look up its score: ");
            string nameToFind = Console.ReadLine() ?? "";
            Assignments.FindValueByKey(persons, nameToFind);

            // =====================================================================
            // Assignment 9: Remove a key from the dictionary (repeatable)
            // Goal: Use Dictionary.Remove and handle missing keys.
            // =====================================================================
            while (true)
            {
                Console.Write("Enter a name to remove from the dictionary: ");
                string keyToRemove = Console.ReadLine() ?? "";
                Assignments.RemoveKeyFromDictionary(persons, keyToRemove);

                Console.WriteLine("\nUpdated dictionary:");
                Assignments.PrintDictionary(persons);

                Console.Write("Do you want to remove another name? (y/n): ");
                string ans2 = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
                if (ans2 != "y") break;
            }

            // =====================================================================
            // Assignment 10: Work with arrays
            // Goal: Practice creating, filling, and printing an array of integers.
            // =====================================================================
            const int arraySize = 5;
            Console.WriteLine($"\n[ARRAY] Enter {arraySize} integers to fill an array:");
            int[] myArray = Assignments.CollectNumbersToArray(arraySize);

            Console.WriteLine("\nNumbers in the array are:");
            Assignments.PrintArray(myArray);

            Console.WriteLine("\nDone. Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
