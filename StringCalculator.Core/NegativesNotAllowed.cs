using System;
using System.Collections;
using System.Collections.Generic;

namespace StringCalculator
{
   public class NegativesNotAllowedException : Exception
   {
      public NegativesNotAllowedException(IEnumerable<int> negativeNumbers)
         : base($"Negative numbers not allowed: {string.Join(',', negativeNumbers)}")
      {

      }
   }
}