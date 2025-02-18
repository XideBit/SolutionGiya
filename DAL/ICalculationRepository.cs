using DAL.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICalculationRepository
    {
        void SaveCalculation(string input1, string input2, string operation, object result);
        public IList<CalculationHistory> GetCalculationHistory(string operation);
    }
}
