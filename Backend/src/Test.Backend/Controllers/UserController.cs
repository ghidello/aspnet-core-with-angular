using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Test.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ApplicationUser Get()
        {
            return new ApplicationUser
            {
                IdentityName = User.Identity?.Name
            };
        }

        public class ApplicationUser
        {
            public string? IdentityName { get; set; }
        }
    }
}