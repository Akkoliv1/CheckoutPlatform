using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine.Interface
{
    /// <summary>
    /// Interface to access various Strategies for Promotion offer.
    /// Like Additional Item offer,Combo offer etc...
    /// </summary>
    public interface IPromotionStrategy
    {
        /// <summary>
        /// Can Execute
        /// </summary>
        /// <param name="product"></param>
        /// <param name="promotions"></param>
        /// <returns></returns>
        bool CanExecute(ProductCheckout product, List<Promotion> promotions);

        /// <summary>
        /// Calculate ProductPrice
        /// </summary>
        /// <param name="productCheckoutList"></param>
        /// <returns></returns>
        double CalculateProductPrice(List<ProductCheckout> productCheckoutList);
    }
}
