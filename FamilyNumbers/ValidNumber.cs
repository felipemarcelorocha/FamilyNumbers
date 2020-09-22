using System;

namespace FamilyNumbers
{
    public class ValidNumber
    {

        public const int maxValue = 100000000;
        public const int minValue = 0;


        public static bool isValidNumber(string number)
        {
            bool isValid = false;
   
            Int32.TryParse(number, out int validNumber);

            if (validNumber <= maxValue && validNumber >= minValue)
                isValid = true;

            return isValid;
        }
    }
}
