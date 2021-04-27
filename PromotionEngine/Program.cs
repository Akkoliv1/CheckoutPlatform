using PromotionEngine.BusinessLayer;
using PromotionEngine.Infrastructure;
using System;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LogWriter.LogWrite("Promotion Engine is initialized : ");
                Facade facade = new Facade();


                facade.CheckoutProducts();///User input for the Product quantity  

                facade.ApplyPromotion();// Apply Promotion offers for the product

                facade.DisplayTotalPrice(); //Display result 

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in Promotion Engine .... : " + ex.Message);
            }
        }
    }
}
