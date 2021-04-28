using PromotionEngine.Entities;
using PromotionEngine.Infrastructure;
using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.PromotionStrategies
{
    public class AdditionalItemOffer : IPromotionStrategy
    {
        private Promotion appliedPromotion;
        private ProductCheckout ProductCheckout;

        public AdditionalItemOffer()
        {
            appliedPromotion = new Promotion();
            ProductCheckout = new ProductCheckout();
        }

        /// <summary>
        /// Can Execute
        /// </summary>
        /// <param name="product"></param>
        /// <param name="promotions"></param>
        /// <returns></returns>
        public bool CanExecute(ProductCheckout product, List<Promotion> promotions)
        {
            ProductCheckout = product;
            appliedPromotion = promotions.Where(x => x.ProductCode == product.ProductCode).FirstOrDefault();
            if (appliedPromotion != null && appliedPromotion.Type == PromotionTypeConstants.Single)
            {
                product.IsValidated = true;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Calculate ProductPrice
        /// </summary>
        /// <param name="productCheckoutList"></param>
        /// <returns></returns>
        public double CalculateProductPrice(List<ProductCheckout> productCheckoutList)
        {
            double finalPrice = 0;
            try
            {
                int totalEligibleItems = ProductCheckout.Quantity / appliedPromotion.Quantity;
                int remainingItems = ProductCheckout.Quantity % appliedPromotion.Quantity;
                finalPrice = appliedPromotion.Price * totalEligibleItems + remainingItems * (ProductCheckout.DefaultPrice);

            }
            catch (ArithmeticException ex)
            {
                LogWriter.LogWrite("Error in AdditionalItemOffer :" + ex.Message);
            }
            catch (Exception e)
            {
                LogWriter.LogWrite("Error in AdditionalItemOffer :" + e.Message);
            }

            return finalPrice;
        }
    }
}
