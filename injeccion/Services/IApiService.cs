using injeccion.Models;

namespace injeccion.Services
{
    public interface IApiService
    {
        Task<UserResponse> LoginAsync(UserRequest request);
    }
}