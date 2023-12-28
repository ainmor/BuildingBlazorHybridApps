using CoffeeBrowser.Library.Data;
using System;
using System.Linq;

namespace CoffeeBrowser.Library.Interfaces;

public interface ICoffeeService
{
    Task<IEnumerable<Coffee>?> LoadCoffeesAsync();
}
