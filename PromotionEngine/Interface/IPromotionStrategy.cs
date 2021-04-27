using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine.Interface
{
    public interface IPromotionStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="promotions"></param>
        /// <returns></returns>
        bool CanExecute(ProductCheckout product, List<Promotion> promotions);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productCheckoutList"></param>
        /// <returns></returns>
        double CalculateProductPrice(List<ProductCheckout> productCheckoutList);
    }
}
