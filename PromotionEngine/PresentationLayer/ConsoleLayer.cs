using PromotionEngine.Entities;
using PromotionEngine.Interface;
using PromotionEngine.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.PresentationLayer
{
   public class ConsoleLayer: IPromotionInputOutput
    {
        ConfigRepository configManagement;

        public ConsoleLayer()
        {
            configManagement = new ConfigRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ProductCheckout> LoadUserInput()
        {

            List<ProductCheckout> checkoutList = new List<ProductCheckout>();
            List<Product> lstProduct = LoadAvilableProducts();

            Console.WriteLine("Enter User Inputs");
            foreach (var item in lstProduct)
            {
                Console.WriteLine("Input quantity of " + item.ProductCode);
                int quantity = Convert.ToInt32(Console.ReadLine());

                checkoutList.Add(new ProductCheckout()
                {
                    ProductCode = item.ProductCode,
                    Quantity = quantity,
                    DefaultPrice = item.Price
                });
            }

            return checkoutList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<Product> LoadAvilableProducts()
        {
            return configManagement.GetAvilableProducts();
        }
        public bool DisplayTotalPrice(Entities.AppliedOffer appliedOffer)
        {
            Console.WriteLine("Calculating Final Price..........................");
            Console.WriteLine("ProductCode" + "-" + "Quantity" + " - " + "FinalPrice" + " - " + "HasOffer");
            foreach (var item in appliedOffer.Checkouts)
            {
                Console.WriteLine(item.ProductCode + "-" + item.Quantity + "-" + item.FinalPrice + "-" + item.HasOffer);
            }
            Console.WriteLine("Total Price : " + appliedOffer.TotalPrice);
            return true;
        }
    }
}
