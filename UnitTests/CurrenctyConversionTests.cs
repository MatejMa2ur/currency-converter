using CurrencyConverter.Api;

namespace UnitTests;

using Xunit;
using System.Collections.Generic;

public class CurrencyServiceTest
{
    [Fact]
    public void ConvertCurrency_ReturnsCorrectValue()
    {
        // Initialize the CurrencyService
        var currencyService = new CurrencyService();
        
        // Set up the dictionary
        Dictionary<string, decimal> rates = new Dictionary<string, decimal>
        {
            {"USD", 1m},
            {"EUR", 0.93m},
            {"GBP", 0.76m},
            {"JPY", 130.53m},
            {"AUD", 1.31m}
        };
        
        decimal amount = 200m;
        string fromCurrency = "USD";
        string toCurrency = "EUR";

        // Call the ConvertCurrency method
        decimal result = currencyService.ConvertCurrency(amount, fromCurrency, toCurrency, rates);

        // Since 200 USD is 186 EUR we can use 186 as result
        Assert.Equal(186, result); 
    }
}