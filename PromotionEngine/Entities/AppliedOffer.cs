using System.Collections.Generic;

namespace PromotionEngine.Entities
{
    public class AppliedOffer
    {
        public List<ProductCheckout> Checkouts { get; set; }
        public double TotalPrice { get; set; }
    }
}
