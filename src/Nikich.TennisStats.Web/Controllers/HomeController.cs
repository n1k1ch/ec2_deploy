using Microsoft.AspNetCore.Mvc;

namespace Nikich.TennisStats.Web.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello";
        }

        [HttpGet("ping")]
        public ActionResult Get(int id)
        {
            return Ok();
        }
    }
}