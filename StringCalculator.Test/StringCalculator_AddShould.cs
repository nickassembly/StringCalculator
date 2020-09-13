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
      public void ReturnSumOfNumbers_GivenTwoNumbers(int expected, string input)
      {
         int result = Calculator.Add(input);

         Assert.Equal(expected, result);
      }


   }
}
