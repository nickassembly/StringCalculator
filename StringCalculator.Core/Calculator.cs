using System;
using System.Globalization;

namespace StringCalculator.Core
{
   public class Calculator
   {
      public static int Add(string numbers)
      {
         string customDelimiter = GetDelimiter(numbers);

         string[] strings = numbers.Split(',', '\n');
         int sum = 0;
         foreach (var s in strings)
         {
            if (int.TryParse(s, out int number))
            {
               sum += number;
            }
         }

         return sum;
      }

      private static string GetDelimiter(Span<char> numbers)
      {
         throw new NotImplementedException();
      }
   }
}
