using PromotionEngine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Interface
{
    public interface IPromotionInputOutput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<ProductCheckout> LoadUserInput();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="appliedOffer"></param>
        /// <returns></returns>
        bool DisplayTotalPrice(Entities.AppliedOffer appliedOffer);
    }
}
