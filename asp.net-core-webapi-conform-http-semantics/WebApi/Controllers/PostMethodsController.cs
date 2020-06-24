using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
    }
}