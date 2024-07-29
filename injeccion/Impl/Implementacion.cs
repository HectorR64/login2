// Implementacion.cs
using injeccion.Models;
using injeccion.Services;

namespace injeccion.Impl
{
    public class Implementacion
    {
        private readonly ILoginService _loginService;

        public Implementacion(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public async Task<UserResponse> HacerAlgoConElResultadoDelLogin(UserRequest request)
        {
            var loginResult = await _loginService.Login(request);

            if (loginResult.IsSuccess)
            {
                // Usuario válido, realizar acciones con loginResult.User
                // ...
                return loginResult.User;
            }
            else
            {
                // Usuario inválido, retornar mensaje de error
                return new UserResponse { is_valid = false, message = "Usuario o contraseña incorrectos" };
            }
        }
    }
}
