namespace PromotionEngine.Entities
{
    public class ProductCheckout
    {
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public double FinalPrice { get; set; }
        public double DefaultPrice { get; set; }
        public bool HasOffer { get; set; }
        public bool IsValidated { get; set; }
    }
}
