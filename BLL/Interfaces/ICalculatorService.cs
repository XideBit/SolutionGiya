using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICalculatorService
    {
        object Calculate(string input1, string input2, string operation);
    }
}
