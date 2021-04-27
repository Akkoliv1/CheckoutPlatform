using PromotionEngine.Entities;
using PromotionEngine.Infrastructure;
using PromotionEngine.Interface;
using PromotionEngine.PromotionStrategies;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Service
{
    /// <summary>
    /// Promotion Service
    /// </summary>
    public class PromotionService : IPromotionService
    {
        /// <summary>
        /// Apply Promotion
        /// </summary>
        /// <param name="checkoutList"></param>
        /// <param name="promotions"></param>
        /// <returns></returns>
        public AppliedOffer ApplyPromotion(List<ProductCheckout> checkoutList, List<Promotion> promotions)
        {
            AppliedOffer appliedOffer = new AppliedOffer();

            //Here Strategy pattern allows a  to choose an algorithm from a family of Promotion algorithms 
            List<IPromotionStrategy> strategies = new List<IPromotionStrategy>();
            strategies.Add(new AdditionalItemOffer());
            strategies.Add(new ComboOffer());

            try
            {
                foreach (ProductCheckout item in checkoutList)
                {
                    if (item.Quantity > 0)
                    {
                        foreach (var strategy in strategies)
                        {
                            if (strategy.CanExecute(item, promotions))
                            {
                                item.HasOffer = true;
                                item.FinalPrice = strategy.CalculateProductPrice(checkoutList);
                                appliedOffer.TotalPrice += item.FinalPrice;
                                break;
                            }
                        }
                    }
                }
                appliedOffer.Checkouts = checkoutList;
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Error in Applying Promotion in PromotionStrategy:" + ex.Message);
            }

            return appliedOffer;
        }


    }
}
