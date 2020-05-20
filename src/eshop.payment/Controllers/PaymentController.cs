using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace eshop.payment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public bool Pay()
        {
            _logger.Log(LogLevel.Information, "Payment successful");
            return true;
        }
    }
}