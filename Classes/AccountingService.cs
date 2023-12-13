using GenericsExample.Interface;

namespace GenericsExample.Classes
{
    public class AccountingService
    {
        public AccountingService() 
        {

        }

        /// <summary>
        /// Method to return consumption percentage.
        /// </summary>
        /// <returns></returns>
        public int GetConsumptionPercentage(int totalItem, int currentItem)
        {
            return totalItem/currentItem * 100;
        }

        /// <summary>
        /// Is expensive if more than 1000.
        /// </summary>
        /// <returns></returns>
        public bool IsProductExpensive<T>(T product) where T : IProductService
        {
            return product.GetProductPrice() > 1000;
        }
    }
}
