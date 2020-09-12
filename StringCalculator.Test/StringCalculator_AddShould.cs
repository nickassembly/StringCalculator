using StringCalculator.Core;
using System;
using Xunit;

namespace StringCalculator.Test
{
   public class StringCalculator_AddShould
   {
      [Fact]
      public void Return0_GivenEmptyString()
      {
         int result = Calculator.Add("");

         Assert.Equal(0, result);
      }
   }
}
