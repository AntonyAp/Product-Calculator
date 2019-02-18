using System.Collections.Generic;

namespace ShopModel
{
    public class SimpleCalculator : IValueCalculator
    {
        public decimal ValueProducts(List<Product> products)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return sumOfProduct;
        }
    }
}
