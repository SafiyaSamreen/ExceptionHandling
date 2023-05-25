using System;
using System.Reflection.Metadata.Ecma335;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        private static void validateString(string stringValue)
        {
            if (stringValue == null)
                throw new ArgumentNullException(nameof(stringValue));

            stringValue = stringValue.Trim();

            if (stringValue == "")
                throw new FormatException(nameof(stringValue));

            for (int i = 0; i < stringValue.Length; i++)
            {
                if (!char.IsDigit(stringValue[i]))
                {
                    if (i == 0 && (stringValue[i] == '+' || stringValue[i] == '-'))
                        continue;

                    throw new FormatException(nameof(stringValue));
                }
            }

            if ((stringValue.Length >= 10 && stringValue != "-2147483648"))
            {
                if (stringValue != "2147483647")
                    throw new OverflowException(nameof(stringValue));
            }
        }
        public int Parse(string stringValue)
        {
            validateString(stringValue);
            stringValue = stringValue.Trim();

            var number = 0;
            bool isNegative = false;

            if (stringValue[0] == '-')
                isNegative = true;

            if (stringValue != "0" && stringValue != "-0" && stringValue != "+0")
            {
                int i = 0;

                while (stringValue[i] == '-' || stringValue[i] == '+' || stringValue[i] == '0')
                    i++;

               for(int j = i; j < stringValue.Length; j++)
                {
                    number = number * 10 + (stringValue[j] - 48);
                }

               if (isNegative)
                    number = number * -1;
            }
            return number;
        }
    }
}