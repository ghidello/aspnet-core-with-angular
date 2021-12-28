using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Test.Backend.Models;

namespace Test.Backend.Controllers
{
    public class HomeController : Controller
    {
        // exposing the angular html through the controller allows to protect it with the global authorization
        // and to ad the csp headers. the script with have the hash in the file name so cashing them forever is allowed
        // -----------------------------------------------------------------------------------------------------------------
        // with a regular view it would be easier to use the ANTIFORGERY token and protect the application from CSRF attacks
        // using the same infrastructure created for the cookies authentication
        // -----------------------------------------------------------------------------------------------------------------
        public IActionResult Index()
        {
            HttpContext.Response.Headers.Add("Content-Security-Policy", "default-src 'self'; style-src 'self' 'unsafe-inline'");

            return File("/index.html", "text/html");
        }
        
        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
