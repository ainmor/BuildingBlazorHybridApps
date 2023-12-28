using CoffeeBrowser.Lib.Data;
using System;
using System.Linq;

namespace CoffeeBrowser.Lib.Interfaces;

public interface ICoffeeService
{
    Task<IEnumerable<Coffee>?> LoadCoffeesAsync();
}
