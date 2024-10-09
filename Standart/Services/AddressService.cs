using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Standart.Models;
using Standart.Services;

public class AddressService : IAddressService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;
    private readonly ILogger<AddressService> _logger;

    public AddressService(IHttpClientFactory httpClientFactory, IConfiguration configuration, ILogger<AddressService> logger)
    {
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
        _logger = logger;
    }

    public async Task<DadataResponseModel> CleanAddressAsync(string rawAddress)
    {
        var client = _httpClientFactory.CreateClient();
        var apiUrl = _configuration["Dadata:BaseUrl"];
        var apiKey = _configuration["Dadata:ApiKey"];
        var secret = _configuration["Dadata:Secret"];

        client.DefaultRequestHeaders.Add("Authorization", $"Token {apiKey}");
        client.DefaultRequestHeaders.Add("X-Secret", secret);

        var response = await client.PostAsJsonAsync(apiUrl, new[] { rawAddress });
        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadFromJsonAsync<DadataResponseModel[]>();
            if (result != null && result.Length > 0)
            {
                return result[0];
            }
        }

        _logger.LogError("Ошибка при запросе к Dadata API: {StatusCode}", response.StatusCode);
        return null;
    }
}
