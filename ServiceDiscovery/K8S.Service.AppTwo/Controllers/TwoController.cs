using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace K8S.Service.AppTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Host()
        {
            string serviceName = "K8S_SERVICE_APPTWO";
            string host = Environment.GetEnvironmentVariable($"{serviceName}_SERVICE_HOST");
            string port = Environment.GetEnvironmentVariable($"{serviceName}_SERVICE_PORT");
            return Ok($"{host}:{port}");
        }
    }
}
