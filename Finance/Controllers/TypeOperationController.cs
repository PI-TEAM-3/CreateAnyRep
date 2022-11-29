using Finance.Infrastructure;
using Finance.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Finance.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypeOperationController : ControllerBase
    {
        private readonly ITypeOperationService _service;

        public TypeOperationController(ITypeOperationService service)
        {
            _service = service;
        }        

        [HttpPost]
        public async Task<ActionResult<TypeOperation>> PostAsync(TypeOperation operation)
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
