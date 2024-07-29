using injeccion.Models;

namespace injeccion.Services
{
    public class LoginService : ILoginService
    {
        private readonly IApiService _apiService;

        public LoginService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<LoginResult> Login(UserRequest request)
        {
            var response = await _apiService.LoginAsync(request);
            return new LoginResult { IsSuccess = response.is_valid, User = response };
        }
    }
}