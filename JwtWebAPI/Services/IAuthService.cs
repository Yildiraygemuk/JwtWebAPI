using JwtWebAPI.Models;

namespace JwtWebAPI.Services
{
    public interface IAuthService
    {
        string GetMyName();
        User Register(UserDto request);
        string Login(UserDto request);
    }
}
