namespace StrategyDesignPattern.Models.ValueObjects
{
    public class IPVA : Tax
    {
        public decimal Calculate(Budget budget)
        {
            return Math.Truncate((decimal)1.20 * budget.Value);
        }
    }
}
