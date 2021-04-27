using PromotionEngine.Entities;
using PromotionEngine.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.PromotionStrategies
{
    public class ComboOffer : IPromotionStrategy
    {
        public double CalculateProductPrice(List<ProductCheckout> productCheckoutList)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute(ProductCheckout product, List<Promotion> promotions)
        {
            throw new NotImplementedException();
        }
    }
}
