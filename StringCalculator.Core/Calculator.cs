using System;

namespace StringCalculator.Core
{
   public class Calculator
   {
      public static int Add(string numbers)
      {
         string[] strings = numbers.Split(",");
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
   }
}
