namespace StrategyDesignPattern.Models.ValueObjects
{
    public class Budget
    {
        public decimal Value { get; private set; }

        public Budget(decimal value)
        {
            Value = value;
        }
    }
}
