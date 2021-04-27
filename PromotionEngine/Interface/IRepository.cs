using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine.Interface
{
    public interface IRepository
    {
        List<Product> GetAvilableProducts();
        List<Promotion> GetProductOffers();
    }
}
