using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Plan : Base
    {
        public required string Title { get; set; }
        public Decimal Price { get; set; }
    }
}