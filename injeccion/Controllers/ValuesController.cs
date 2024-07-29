using injeccion.Services;
using injeccion.Models;
using Microsoft.AspNetCore.Mvc;
using injeccion.Impl;

namespace injeccion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly Implementacion _implementacion;

        public ValuesController(ILoginService loginService, Implementacion implementacion)
        {
            _loginService = loginService;
            _implementacion = implementacion;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserRequest request)
        {
            var result = await _implementacion.HacerAlgoConElResultadoDelLogin(request);
            return Ok(result);
        }
    }
}
