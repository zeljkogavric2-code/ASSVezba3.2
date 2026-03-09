
namespace LegacyOrderSystem.Services
{
    public class DiscountService
    {
        public decimal Apply(decimal total)
        {
            if (total > 1000) return total * 0.9m;
            return total;
        }
    }
}
