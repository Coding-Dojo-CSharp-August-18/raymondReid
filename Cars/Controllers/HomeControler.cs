using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dbConnection;
namespace Cars.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            return View();
            //OR
            //return View("Index");
            //Both of these returns will render the same view (You only need one!)
        }
    }
}