using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsynchronousOperationsController : ControllerBase
    {
        [Route("processmovie")]
        [HttpPost]
        public IActionResult ProcessMovie(Movie movie)
        {
            return AcceptedAtAction(nameof(Status), new { processId = 12345 }, movie);
        }

        [Route("status")]
        [HttpGet]
        public IActionResult Status(int processId)
        {
            return Ok(new { status = "In progress" });
        }
    }
}