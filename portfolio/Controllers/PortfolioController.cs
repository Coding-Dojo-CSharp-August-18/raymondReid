using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private const string V = "{name}";

        // inputs
        [Route("")]
        [HttpGet]

        //output/ actions
        public string Index()
        {
            return "This in the index page!!!!";
        }

        [HttpGet("projects")]

        public string Projects()
        {
            return "These are the projects";
        }

        [HttpGet("contact")]

        public string Contact()
        {
            return "These are my Contacts";
        }

    }
}