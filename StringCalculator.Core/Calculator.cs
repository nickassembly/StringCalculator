﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StringCalculator.Core
{
   public class Calculator
   {
      public static int Add(string numbers)
      {
         string[] delimiters = GetDelimiters(numbers);
         string[] strings = numbers.Split(delimiters, StringSplitOptions.None);
         List<int> numberList = new List<int>();
         foreach (var s in strings)
         {
            if (int.TryParse(s, out int number))
            {
               numberList.Add(number);
            }
         }

         CheckForNegativeNumbers(numberList);
         numberList.RemoveAll(x => x > 1000);
         return numberList.Sum();
      }

      private static void CheckForNegativeNumbers(List<int> numberList)
      {
         var negativeNumbers = numberList.Where(x => x < 0).ToList();

         if (negativeNumbers.Any())
         {
            throw new NegativesNotAllowedException(negativeNumbers);
         }
      }

      private static string[] GetDelimiters(string numbers)
      {
         var delimiters = new List<string> { ",", "\n" };
         if (numbers.StartsWith("//"))
         {
            string customDelim = numbers.Split('\n').First().Substring(2);
            if (customDelim.StartsWith('['))
            {
               delimiters.Add(customDelim.Substring(1, customDelim.Length - 2));
            }
            else
            {
               delimiters.Add(customDelim);
            }
         }

         return delimiters.ToArray();
      }
   }
}
