using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace K8S.Service.AppOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OneController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string appTwoUrl = "http://k8s-service-apptwo/api/two";
            HttpClient httpClient = new HttpClient();
            var content = httpClient.GetStringAsync(appTwoUrl).Result;
            return Ok(content);
        }
    }
}
