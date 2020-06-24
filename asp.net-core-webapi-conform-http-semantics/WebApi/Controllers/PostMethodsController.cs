using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostMethodsController : ControllerBase
    {
        [Route("createmovie")]
        [HttpPost]
        public IActionResult CreateMovie(Movie movie)
        {
            return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var movie = new Movie
            {
                Id = 2,
                Name = "The dark knight",
                Director = "Christopher Nolan",
                Year = 2008
            };

            return Ok(movie);
        }

        [Route("processmovie")]
        [HttpPost]
        public IActionResult ProcessMovie(Movie movie)
        {
            return Ok(new { result = "Sucessful" });
        }

        [Route("postnoresult")]
        [HttpPost]
        public IActionResult PostNoResult(Movie movie)
        {
            return new NoContentResult();
        }
    }
}