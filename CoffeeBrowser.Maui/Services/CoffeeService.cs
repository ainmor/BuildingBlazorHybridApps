using CoffeeBrowser.Lib.Data;
using CoffeeBrowser.Lib.Interfaces;
using System;
using System.Linq;
using System.Net.Http.Json;

namespace CoffeeBrowser.Maui.Services;

public class CoffeeService : ICoffeeService
{
    private readonly HttpClient _httpClient = new();
    // Load coffees
    public async Task<IEnumerable<Coffee>?> LoadCoffeesAsync()
    {
        var coffees = await _httpClient.GetFromJsonAsync<IEnumerable<Coffee>>
            ("https://fake-coffee-api.vercel.app/api");
         
        return coffees;
    }
}
