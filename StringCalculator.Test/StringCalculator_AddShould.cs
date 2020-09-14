using StringCalculator.Core;
using System;
using Xunit;

namespace StringCalculator.Test
{
   public class StringCalculator_AddShould
   {
      [Theory]
      [InlineData(1, "1")]
      [InlineData(2, "2")]
      [InlineData(24, "24")]
      public void ReturnTheNumber_GivenSingleNumberString(int expected, string input)
      {
         int result = Calculator.Add(input);

         Assert.Equal(expected, result);
      }

      [Theory]
      [InlineData(2, "1,1")]
      [InlineData(3, "1,2")]
      [InlineData(13, "11,2")]
      public void ReturnSumOfNumbers_GivenTwoNumbers(int expected, string input)
      {
         int result = Calculator.Add(input);

         Assert.Equal(expected, result);
      }

      [Theory]
      [InlineData(11, "1,1,2,3,4")]
      [InlineData(9, "1,2,2,2,2")]
      [InlineData(36, "11,2,23")]
      public void ReturnSumOfNumbers_GivenMoreThanTwoNumbers(int expected, string input)
      {
         int result = Calculator.Add(input);

         Assert.Equal(expected, result);
      }

      [Theory]
      [InlineData(36, "11\n2,23")]
      public void ReturnSumOfNumbers_GivenNewLineSeparators(int expected, string input)
      {
         int result = Calculator.Add(input);

         Assert.Equal(expected, result);
      }


   }
}
