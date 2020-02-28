using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCore3._1.Models;

namespace AspNetCore3._1.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("{recordId}/Edit")]
        public IActionResult EditRecord(Guid recordId)
        {
            string url1 = Url.Action(nameof(UpdateRecord), "Home");
            string url2 = Url.Action(nameof(ViewRecord), "Home");

            var res = $"UpdateRecord: '{url1}'\nViewRecord: '{url2}'";

            return Ok(res);
        }

        [HttpGet("{recordId}/View")]
        public IActionResult ViewRecord(Guid recordId)
        {
            return Ok();
        }

        [HttpPost("{recordId}")]
        public IActionResult UpdateRecord(Guid recordId)
        {
            return Ok();
        }


        public IActionResult Index()
        {
            return Ok("Hello world!");
        }

    }
}
