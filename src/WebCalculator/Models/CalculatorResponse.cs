namespace WebCalculator.Models;

public class CalculatorResponse
{
    public bool Success { get; set; }
    public double Result { get; set; }
    public string Error { get; set; } = string.Empty;
}