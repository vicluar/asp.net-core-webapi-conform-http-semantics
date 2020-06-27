using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PutMethodsController : ControllerBase
    {
        [Route("putcreatemovie")]
        [HttpPut]
        public IActionResult CreateMovie(Movie movie)
        {
            return CreatedAtAction(nameof(GetPutMovieById), new { id = movie.Id }, movie);
        }

        [Route("putupdatemovie")]
        [HttpPut]
        public IActionResult UpdateMovie(Movie movie)
        {
            return Ok(new { result = "Successful" });
        }

        [Route("putupdatemovienoresult")]
        [HttpPut]
        public IActionResult UpdateMovieNoResult(Movie movie)
        {
            return new NoContentResult();
        }

        [Route("notpossibleupdatedueconflict")]
        [HttpPut]
        public IActionResult NotPossibleUpdateDueConflict(Movie movie)
        {
            return Conflict();
        }

        [HttpGet]
        public IActionResult GetPutMovieById(int id)
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
    }
}