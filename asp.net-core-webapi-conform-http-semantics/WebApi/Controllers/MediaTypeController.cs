using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaTypeController : ControllerBase
    {
        [Route("addmoviecontenttypeexample")]
        [HttpPost]
        public IActionResult AddMovieContentTypeExample([FromBody] Movie movie)
        {
            return Ok(movie);
        }

        [HttpGet]
        public IActionResult Get()
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