using System;
using System.Collections.Generic;
using System.Text;

namespace Kaleidocode.Katas.Libraries.Parsers
{
    public class StringParser
    {
        public static IEnumerable<int> CollectNumbers(string input)
        {
            var stringBuilder = new StringBuilder();

            if (string.IsNullOrEmpty(input))
            {
                return [0];
            }

            foreach (char c in input)
            {
                var isNumericValue = c.Equals('-') || int.TryParse(c.ToString(), out _);
                
                if (isNumericValue)
                { 
                    stringBuilder.Append(c); 
                }
                else
                {
                    if (!stringBuilder[^1].Equals(',')) 
                    { stringBuilder.Append(','); }
                }

            }

            List<int> acceptedValues = [];

            foreach (var value in stringBuilder.ToString().Split(','))
            {
                if (int.TryParse(value, out int parsedValue))
                {
                    acceptedValues.Add(parsedValue);
                }
            }

            return acceptedValues.AsEnumerable();
        }

    }
}
