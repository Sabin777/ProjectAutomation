using System;

namespace AutomationService
{
    public class Calculator
    {
       public decimal Add(decimal firstDecimal, decimal secondDecimal)
        {
            decimal result;
            result = firstDecimal + secondDecimal;
            return result; 
        } 
    }
}
