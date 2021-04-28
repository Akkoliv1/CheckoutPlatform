using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine.Interface
{
    /// <summary>
    /// Interface to access various functionalities for the Promotion functionality .
    /// </summary>
    public interface IPromotionService
    {
        /// <summary>
        /// Apply Promotion for the User checkout ,considering avilable offers
        /// </summary>
        /// <param name="checkoutList"></param>
        /// <param name="promotions"></param>
        /// <returns></returns>
        AppliedOffer ApplyPromotion(List<ProductCheckout> checkoutList, List<Promotion> promotions);
    }
}
