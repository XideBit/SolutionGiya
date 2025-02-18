using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Actions
{
    public class Division : ICalculator { public double Calculate(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException(); }
}
