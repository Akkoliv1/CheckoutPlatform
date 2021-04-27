using NUnit.Framework;
using PromotionEngine.Entities;
using PromotionEngine.Interface;
using PromotionEngine.PromotionStrategies;
using System.Collections.Generic;


namespace PromotionEngine.Test
{
    public class AdditionalItemOfferTest
    {
        List<Promotion> _promotions;
        ProductCheckout _productWithOffer;
        ProductCheckout _productWithoutOffer;
        ProductCheckout _productWithOfferExtra;
        IPromotionStrategy _promotionStrategy;

        [SetUp]
        public void Setup()
        {
            _promotionStrategy = new AdditionalItemOffer();
            _productWithOffer = new ProductCheckout() { ProductCode = "A", Quantity = 3, DefaultPrice = 50 };
            _productWithOfferExtra = new ProductCheckout() { ProductCode = "A", Quantity = 4, DefaultPrice = 50 };
            _productWithoutOffer = new ProductCheckout() { ProductCode = "A", Quantity = 2, DefaultPrice = 50 };
            _promotions = new List<Promotion>() { new Promotion() { Type = "Single", ProductCode = "A", Price = 130, Quantity = 3 }, new Promotion() { Type = "Single", ProductCode = "B", Price = 45, Quantity = 2 }, new Promotion() { Type = "Combo", ProductCode = "C;D", Price = 30, Quantity = 3 } };
        }

        [Test]
        public void Scenario_AdditionalItemOffer_WithOffer()
        {
            List<ProductCheckout> orderCart = new List<ProductCheckout>();
            orderCart.Add(_productWithOffer);
            double expectedValue = 130;
            bool canExecute = _promotionStrategy.CanExecute(_productWithOffer, _promotions);
            if (canExecute)
            {
                double actualValue = _promotionStrategy.CalculateProductPrice(orderCart);
                Assert.AreEqual(expectedValue, actualValue);
            }

        }

        [Test]
        public void Scenario_AdditionalItemOffer_WithOffer_ExtraItems()
        {
            List<ProductCheckout> orderCart = new List<ProductCheckout>();
            orderCart.Add(_productWithOfferExtra);
            double expectedValue = 180;
            bool canExecute = _promotionStrategy.CanExecute(_productWithOfferExtra, _promotions);
            if (canExecute)
            {
                double actualValue = _promotionStrategy.CalculateProductPrice(orderCart);
                Assert.AreEqual(expectedValue, actualValue);
            }

        }
        [Test]
        public void Scenario_AdditionalItemOffer_WithoutOffer()
        {
            List<ProductCheckout> orderCart = new List<ProductCheckout>();
            orderCart.Add(_productWithoutOffer);
            double expectedValue = 100;
            bool canExecute = _promotionStrategy.CanExecute(_productWithoutOffer, _promotions);
            if (canExecute)
            {
                double actualValue = _promotionStrategy.CalculateProductPrice(orderCart);
                Assert.AreEqual(expectedValue, actualValue);
            }

        }
    }
}
