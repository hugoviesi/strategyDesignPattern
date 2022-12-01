using StrategyDesignPattern.Models;
using StrategyDesignPattern.Models.ValueObjects;

Console.Write("Digite o valor do orçamento: ");
var value = decimal.Parse(Console.ReadLine());

var budget = new Budget(value);

Tax icms = new ICMS();
Tax ipva = new IPVA();

Console.WriteLine($"Orçamento + ICMS: {icms.Calculate(budget)}");
Console.WriteLine($"Orçamento + IPVA: {ipva.Calculate(budget)}");

Console.ReadKey();