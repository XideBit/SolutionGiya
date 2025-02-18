using BLL.Interfaces;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Presentation.Model;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        private readonly ICalculatorService _calculatorService;
        private readonly ICalculationRepository _calculationRepository;

        public CalculatorController(ICalculatorService calculatorService, ICalculationRepository calculationRepository)
        {
            _calculatorService = calculatorService;
            _calculationRepository = calculationRepository;
        }

        [HttpPost]
        public IActionResult Calculate([FromBody] CalculationRequest request)
        {
            var result = _calculatorService.Calculate(request.Input1, request.Input2, request.Operation);
            _calculationRepository.SaveCalculation(request.Input1, request.Input2, request.Operation, result);

            //var bonusList= _calculationRepository.GetCalculationHistory(request.Operation);
            return Ok(new { result });
        }
    }
}
