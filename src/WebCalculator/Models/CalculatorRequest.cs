namespace WebCalculator.Models;

public class CalculatorRequest
{
    public double Number1 { get; set; }
    public double Number2 { get; set; }
    public string Operation { get; set; } = string.Empty;
}