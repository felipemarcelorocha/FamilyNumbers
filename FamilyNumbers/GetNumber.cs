using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyNumbers
{
    public class GetNumber
    {
        public const string invalidNumber = "-1";
        public static void startUp (string number)
        {
            Console.WriteLine(ValidNumber.isValidNumber(number) ? getBiggestBrotherNumber(number) : invalidNumber);
        }

        public static string getBiggestBrotherNumber(string number)
        {
            List<string> numbers = new List<string>();

            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add(number[i].ToString());
            }

            numbers = numbers.OrderByDescending(x => x).ToList();

           return string.Join("", numbers);
        }
    }
}
