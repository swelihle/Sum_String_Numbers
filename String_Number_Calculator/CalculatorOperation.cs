using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Number_Calculator
{
    public class CalculatorOperation
    {
        public int Add(string input)
        {
            if (input == "") return 0;
            var delimiters = PDelimiters(ref input);
            var numbers = PNambers(input, delimiters);

            IsThereNegative(numbers);
            return numbers.Sum();
        }
        //-- Parsing Deliminator
        // Return Array of Delimiters
        private static string[] PDelimiters(ref string input)
        {
            //List known delimiters
            var delimiters = new List<string> { ",", "\n" };

            //Get specified delimiters
            // If String start with "//"
            if (input.StartsWith("//"))
            {
                var index = input.IndexOf("\n");
                //Add new delimiter to the delimiters-list
                delimiters.Add(input.Substring(2, index - 2));
                //Get the new number-strings after newLine("\n")
                //And set it to the update input param
                input = input.Substring(index + 1);
            }
            return delimiters.ToArray();
        }
        // END pDelimiters

        //Take Input String(input) AND delimiters
        //Return 
        private static List<int> PNambers(string input, string[] delimiters)
        {
            return input.Split(delimiters.ToArray(), StringSplitOptions.None)
                .Select(int.Parse)
                .ToList();
        }
        // END pNambers
        private static void IsThereNegative(List<int> numbers)
        {
            var negs = numbers.Where(n => n < 0).ToList();
            if (negs.Any())
                throw new ArgumentException("Negative Number not allowed" +
                    string.Join(",", negs));
        }
        // END IsThereNegative
    }
}
