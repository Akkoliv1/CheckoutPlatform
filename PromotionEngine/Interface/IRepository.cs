using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine.Interface
{
    /// <summary>
    /// Interface to access data for various functionalities .
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Get AvilableProducts
        /// </summary>
        /// <returns></returns>
        List<Product> GetAvilableProducts();

        /// <summary>
        /// Get ProductOffers
        /// </summary>
        /// <returns></returns>
        List<Promotion> GetProductOffers();
    }
}
