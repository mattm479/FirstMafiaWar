using FirstMafiaWar.Models.Requests;
using FirstMafiaWar.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstMafiaWar.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> _logger;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(ILogger<AuthenticationController> logger, IAuthenticationService authenticationService)
        {
            _logger = logger;
            _authenticationService = authenticationService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authenticationService.RegisterAsync(request, cancellationToken);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authenticationService.LoginAsync(request, cancellationToken);
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(response);
        }
    }
}
