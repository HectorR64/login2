using injeccion.Models;
using injeccion.Services;
using Microsoft.AspNetCore.Identity.Data;
using System.Text.Json;

public class ApiServiceImpl : IApiService
{
    private readonly IConfiguration _configuration;
    private readonly HttpClient _httpClient;

    public ApiServiceImpl(IConfiguration configuration, HttpClient httpClient)
    {
        _configuration = configuration;
        _httpClient = httpClient;
    }

    public async Task<UserResponse> LoginAsync(UserRequest request)
    {
        var apiUrl = _configuration["ApiUrl"];
        var url = $"{apiUrl}/api/login";

        var json = JsonSerializer.Serialize(request);
        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

        var
     response = await _httpClient.PostAsync(url, content);

        if (response.IsSuccessStatusCode)

        {
            var userResponse = await response.Content.ReadFromJsonAsync<UserResponse>();
            userResponse.is_valid = true;
            return userResponse;
        }
        else
        {
            // Manejo de errores
            return new UserResponse { is_valid = false };
        }
    }
}
