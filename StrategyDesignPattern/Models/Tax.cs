using StrategyDesignPattern.Models.ValueObjects;

namespace StrategyDesignPattern.Models
{
    public interface Tax
    {
        decimal Calculate(Budget budget);
    }
}
