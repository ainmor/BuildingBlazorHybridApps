using System;
using System.Linq;
using CoffeeBrowser.Maui.Data;

namespace CoffeeBrowser.Maui.Services;

public interface ICoffeeService
{
    Task<IEnumerable<Coffee>?> LoadCoffeesAsync();
}
