using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        // we can see this as contact every class that uses this or implement has to use CreateToken
        string CreateToken(AppUser user);
    }
}

