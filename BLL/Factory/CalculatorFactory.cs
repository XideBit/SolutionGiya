using BLL.Actions;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Factory
{
    public static class CalculatorFactory
    {
        public static ICalculator GetCalculator(string operation)
        {
            return operation.ToLower() switch
            {
                "plus" => new Addition(),
                "minus" => new Subtraction(),
                "multiply" => new Multiplication(),
                "divide" => new Division(),
                _ => throw new ArgumentException("Invalid operation")
            };
        }
    }
}
