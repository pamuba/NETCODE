using Microsoft.AspNetCore.Identity;

namespace CoreWEBAPIDemos.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
