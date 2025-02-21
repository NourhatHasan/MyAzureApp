using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;



[Authorize]
[Route("api/[controller]")]
public class ExampleController : ControllerBase
{
  
    
    [HttpGet]
    public IActionResult Get()
    {
        var user = HttpContext.User;
        if (user.Identity != null && user.Identity.IsAuthenticated)
        {
            var claims = user.Claims.Select(c => new { c.Type, c.Value });

            return Ok(new { message = "Hello from Example API!", claims });
        }
        else
        {
            return Unauthorized("User is not authenticated");
        }
    }

}