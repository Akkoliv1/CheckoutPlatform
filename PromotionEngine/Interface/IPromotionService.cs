using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine.Interface
{
    public interface IPromotionService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkoutList"></param>
        /// <param name="promotions"></param>
        /// <returns></returns>
        AppliedOffer ApplyPromotion(List<ProductCheckout> checkoutList, List<Promotion> promotions);
    }
}
