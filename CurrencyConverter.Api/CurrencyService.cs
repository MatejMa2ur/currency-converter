namespace CurrencyConverter.Api;

public class CurrencyService
{
    public decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency, Dictionary<string, decimal> rates)
    {
        decimal rateToUSD = rates[fromCurrency];
        decimal amountInUSD = amount / rateToUSD;
        decimal targetRate = rates[toCurrency];
        return amountInUSD * targetRate;
    }
}