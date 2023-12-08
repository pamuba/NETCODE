using CoreWEBAPIDemos.Models.DTO;
using CoreWEBAPIDemos.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CoreWEBAPIDemos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }


        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {

            var identityUser = new IdentityUser
            {
                UserName = registerRequestDto.Username,
                Email = registerRequestDto.Username
            };

            var identityResult = await userManager.CreateAsync(identityUser, registerRequestDto.Password);

            if (identityResult.Succeeded)
            {
                //Add roles to the user
                if (registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
                {
                    identityResult = await userManager.AddToRolesAsync(identityUser, registerRequestDto.Roles);

                    if (identityResult.Succeeded)
                    {
                        return Ok("User Registeres! Please Login");
                    }
                }
            }
            return BadRequest("Somthing Went Wrong");
        }


        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestsDto loginRequestsDto)
        {
            var user = await userManager.FindByEmailAsync(loginRequestsDto.Username);

            if (user != null) {

                var chcekPasswordResult =  await userManager.CheckPasswordAsync(user, loginRequestsDto.Password);

                if (chcekPasswordResult) {

                    // get the rolse for this user
                    var roles = await userManager.GetRolesAsync(user);
                    //Create the  jwt token
                    if (roles != null)
                    {
                        var jwtToken = tokenRepository.CreateJWTToken(user, roles.ToList());

                        var response = new LoginResponseDto
                        {
                            JwtToken = jwtToken,
                        };

                        return Ok(response);

                    }
                }
            }
            return BadRequest("Username or Password incorrect");
        }
    }
}
