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
            return AcceptedAtAction(nameof(Status), new { processId = 12345 }, new Movie());
        }

        [Route("processmovietocomplete")]
        [HttpPost]
        public IActionResult ProcessMovieToComplete(Movie movie)
        {
            return AcceptedAtAction(nameof(StatusComplete), new { processId = 6789 }, movie);
        }

        [Route("statuscomplete")]
        [HttpGet]
        public IActionResult StatusComplete(int processId)
        {
            return RedirectToAction(nameof(FetchResource), new { id = 12345 });
        }

        [Route("fetchresource")]
        [HttpGet]
        public IActionResult FetchResource(int id)
        {
            return Ok(new Movie());
        }
    }
}