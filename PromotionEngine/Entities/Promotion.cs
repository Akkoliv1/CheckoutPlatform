namespace PromotionEngine.Entities
{
    public class Promotion
    {
        public int PromotionId { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string ProductCode { get; set; }
        public double Price { get; set; }
    }
}
