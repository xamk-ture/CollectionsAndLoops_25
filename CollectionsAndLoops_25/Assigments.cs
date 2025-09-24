using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsAndLoops_25
{
    internal static class Assignments
    {
        /*
         ============================================================================
         Assignment 1: Collect numbers to list
         Goal:
           - Read 'count' integers from the console.
           - Store them to a new List<int> in the same order as entered.
           - Use a for-loop + ReadInt helper that validates the input (see bottom).
         Constraints:
           - No LINQ; use basic loops and List.Add.
         Examples:
           Input (count = 5):  4 2 8 6 10
           Output List:        [4, 2, 8, 6, 10]
         Links:
           For-loop:   https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForExample/Program.cs
           List<T>:    https://github.com/xamk-ture/FundamentalsExamples/blob/master/ListExample/Program.cs
         ============================================================================
        */
        public static List<int> CollectNumbersToList(int count)
        {
            throw new NotImplementedException("Implement collecting integers to a List<int> using the linked examples.");
        }

        /*
         ============================================================================
         Assignment 2: Print list values
         Goal:
           - Print each number on its own line, in order.
           - Use foreach over IEnumerable<int>.
         Links:
           Foreach-loop: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForeachExample/Program.cs
         ============================================================================
        */
        public static void PrintList(IEnumerable<int> numbers)
        {
            // TODO:
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 3: Calculate average (no LINQ)
        /// Goal:
        ///   - Sum all numbers with a for-loop and divide by Count.
        ///   - Return 0.0 for an empty list to avoid division by zero.
        /// Constraints:
        ///   - Do NOT use LINQ (Average/Min/Max).
        /// Links:
        ///   For-loop sum example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ForExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static double CalculateAverage(List<int> numbers)
        {
            // TODO:
            throw new NotImplementedException("Sum with for-loop and divide by Count; handle empty list.");
        }

        /*
         ============================================================================
         Assignment 4: Find min and max (no LINQ)
         Goal:
           - Read the list once and track current min and max using comparisons.
         Constraints:
           - If the list is empty, set min=0 and max=0.
         Links:
           Min/Max logic example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/MinMaxExample/Program.cs
         ============================================================================
        */
        public static void FindMinAndMax(List<int> numbers, out int min, out int max)
        {
            // TODO:
            throw new NotImplementedException("Walk the list once and track current min and max.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 3 (part B): Filter values greater than a threshold
        /// Goal:
        ///   - Build and return a NEW List<int> containing items strictly greater than 'threshold'.
        /// Constraints:
        ///   - Use foreach + if + List.Add; no LINQ.
        /// Links:
        ///   Filtering example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/IfExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static List<int> FindAboveThreshold(List<int> numbers, int threshold)
        {
            // TODO:
            throw new NotImplementedException("Build a new list containing items > threshold.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 4: Remove a number from the list
        /// Goal:
        ///   - Try to remove 'number' using List.Remove.
        ///   - Print feedback.
        /// Links:
        ///   List.Remove example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ListExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static void RemoveNumberFromList(List<int> numbers, int number)
        {
            // TODO:
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 5 : Add random numbers to the list (inclusive range)
        /// Goal:
        ///   - Append 'count' random integers in the range [min, max] to 'list'.
        /// Notes:
        ///   - If count <= 0, do nothing.
        /// Links:
        ///   Random usage: https://github.com/xamk-ture/FundamentalsExamples/blob/master/RandomExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static void AddRandomNumbers(List<int> list, int count, int min, int max)
        {
            // TODO:
        }

        // -----------------------------------------------------------------
        // DICTIONARY FUNCTIONS
        // -----------------------------------------------------------------

        /// <summary>
        /// ============================================================================
        /// Assignment 6: Collect (name, age) pairs to dictionary (unique keys)
        /// Goal:
        ///   - Read 'count' pairs from console: name (string), age (int).
        ///   - Store into Dictionary&lt;string,int&gt; with unique names (keys).
        ///   - If a name already exists, re-prompt for a different name.
        /// Links:
        ///   Dictionary basics: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static Dictionary<string, int> CollectDataToDictionary(int count)
        {
            // TODO:
            throw new NotImplementedException("Fill a Dictionary<string,int> with unique (name, score) pairs.");
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 7: Print dictionary with foreach over KeyValuePair
        /// Goal:
        ///   - Print each entry as: "Key:{name} Value:{age}" (one per line).
        ///   - If dictionary is empty, print "(Empty)".
        /// Links:
        ///   Dictionary foreach example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static void PrintDictionary(Dictionary<string, int> dict)
        {
            // TODO:
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 8: Find value by key
        /// Goal:
        ///   - Print the score if found, else "Not found: {key}".
        /// Links:
        ///   Dictionary lookup example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static void FindValueByKey(Dictionary<string, int> dict, string key)
        {
            // TODO:
           
        }

        /// <summary>
        /// ============================================================================
        /// Assignment 9: Remove key from dictionary
        /// Goal:
        ///   - Remove the entry with 'key' and print feedback.
        /// Links:
        ///   Dictionary.Remove example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/DictionaryExample/Program.cs
        /// ============================================================================
        /// </summary>
        public static void RemoveKeyFromDictionary(Dictionary<string, int> dict, string key)
        {
            // TODO:
        }

        /*
        ============================================================================
        Assignment 10a: Collect numbers into an array
        Goal:
          - Read 'count' integers and store them in a fixed-size int[] array.
          - Use a for-loop and the provided ReadInt helper.
        Constraints:
          - Use array indexing (arr[i]) to assign values.
        Links:
          Array basics: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ArrayExample/Program.cs
        ============================================================================
        */
        public static int[] CollectNumbersToArray(int count)
        {
            // TODO:
            throw new NotImplementedException("Create an int[] of size 'count' and fill it using a for-loop and ReadInt.");
        }

        /*
         ============================================================================
         Assignment 10b: Print array values
         Goal:
           - Print each element of the given int[] on its own line.
           - Use foreach or for-loop to iterate.
         Links:
           Array print example: https://github.com/xamk-ture/FundamentalsExamples/blob/master/ArrayExample/Program.cs
         ============================================================================
        */
        public static void PrintArray(int[] numbers)
        {
            // TODO:
            throw new NotImplementedException("Loop through the array and print each number on its own line.");
        }

        // -----------------------------------------------------------------
        // HELPER (ready to use as-is)
        // -----------------------------------------------------------------
        /// <summary>
        /// Helper: Read a valid integer from console, re-prompting on invalid input.
        /// If <paramref name="prompt"/> is null or empty, no prompt is shown.
        /// Uses int.TryParse with InvariantCulture.
        /// </summary>
        public static int ReadInt(string? prompt)
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(prompt))
                    Console.Write(prompt);

                string input = Console.ReadLine();

                if (int.TryParse(input, out int n))
                    return n;

                Console.WriteLine("Please enter a valid integer.");
            }
        }
    }
}
