using injeccion.Models;

namespace injeccion.Services
{
    public interface ILoginService
    {
        Task<LoginResult> Login(UserRequest request);
    }
}