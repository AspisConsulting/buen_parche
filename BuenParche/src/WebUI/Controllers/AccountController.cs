using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuenParche.WebUI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> ExternalLogin(string provider, string returnUrl) { 
    
        var redirectUrl = Url.Action("ExternalLoginCallback","Account",new { ReturnUrl = returnUrl });
        await Task.FromResult(0); 
        return Redirect("");
    }

    [AllowAnonymous]
    public async Task<IActionResult> ExternalLoginCallback(string returnUrl= null, string remoteError = null) { 
    
        returnUrl = returnUrl ?? Url.Content("~/");
        await Task.FromResult(0);
        return Redirect("");
    }

}
