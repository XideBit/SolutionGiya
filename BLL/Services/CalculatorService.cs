using BLL.Factory;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CalculatorService : ICalculatorService
    {
        public object Calculate(string input1, string input2, string operation)
        {
            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
            {
                var calculator = CalculatorFactory.GetCalculator(operation);
                return calculator.Calculate(num1, num2);
            }
            else
            {
                return input1 + input2;
            }
        }
    }
}
