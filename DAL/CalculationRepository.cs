using DAL.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CalculationRepository : ICalculationRepository
    {
        private readonly AppDbContext _appDbContext;
        public CalculationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void SaveCalculation(string input1, string input2, string operation, object result)
        {
            CalculationHistory history = new CalculationHistory()
            {
                Operand1 = input1,
                Operand2 = input2,
                Operation = operation,
                CreatedAt = DateTime.Now,
                Result = result.ToString(),
            };

            _appDbContext.Add(history);
            _appDbContext.SaveChanges();
        }

        public IList<CalculationHistory> GetCalculationHistory(string operation)
        {
            var currentDate = DateTime.Now;

            var res = _appDbContext.CalculationHistories.GroupBy(ch => ch.Operation == operation).ToList();

            return null;
        }
    }
}
