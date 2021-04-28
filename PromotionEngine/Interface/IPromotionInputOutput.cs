using PromotionEngine.Entities;
using System.Collections.Generic;

namespace PromotionEngine.Interface
{
    /// <summary>
    /// Interface to access various functionalities for presentation .
    /// </summary>
    public interface IPromotionInputOutput
    {
        /// <summary>
        /// Load UserInput
        /// </summary>
        /// <returns></returns>
        List<ProductCheckout> LoadUserInput();

        /// <summary>
        /// Display TotalPrice
        /// </summary>
        /// <param name="appliedOffer"></param>
        /// <returns></returns>
        bool DisplayTotalPrice(Entities.AppliedOffer appliedOffer);
    }
}
