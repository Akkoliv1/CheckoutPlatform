using PromotionEngine.Entities;
using PromotionEngine.Infrastructure;
using PromotionEngine.Interface;
using PromotionEngine.Repository;
using System;
using System.Collections.Generic;

namespace PromotionEngine.Service
{
    /// <summary>
    /// Promotion Service
    /// </summary>
    public class PromotionService : IPromotionService
    {
        ConfigRepository _configManagement;
        List<Promotion> _promotions;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="checkoutList"></param>
        /// <param name="promotions"></param>
        /// <returns></returns>
        public AppliedOffer ApplyPromotion(List<ProductCheckout> checkoutList, List<Promotion> promotions)
        {
            AppliedOffer appliedOffer = new AppliedOffer();
            try
            {
            //TODO
            }            
            catch (Exception ex)
            {

                LogWriter.LogWrite("Error in Applying Promotion in PromotionStrategy:" + ex.Message);
            }

            return appliedOffer;
        }


    }
}
