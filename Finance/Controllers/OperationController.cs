using Finance.Infrastructure;
using Finance.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Finance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperationController : ControllerBase
    {
        private readonly IFinanceOperationService _service;

        public OperationController(IFinanceOperationService service)
        {
            _service = service;
        }      

        [HttpPost]
        public async Task<ActionResult<FinanceOperation>> PostAsync(FinanceOperation operation)
        {
            if (operation == null)
            {
                return BadRequest();
            }

            await _service.CreateAsync(operation);

            return Ok(operation);
        }
    }
}
