namespace StrategyDesignPattern.Models.ValueObjects
{
    public class ICMS : Tax
    {
        public decimal Calculate(Budget budget)
        {
            return Math.Truncate((decimal)1.10 * budget.Value);
        }
    }
}
