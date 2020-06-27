using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteMethodsController : ControllerBase
    {
        [Route("deletemovie")]
        [HttpDelete]
        public IActionResult DeleteMovie(int movieId)
        {
            return NoContent();
        }

        [Route("notfoundtodelete")]
        [HttpDelete]
        public IActionResult NotFoundToDelete(int movieId)
        {
            return NotFound();
        }
    }
}