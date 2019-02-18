using System.Collections.Generic;

namespace ShopModel
{
    public class CalculatorWithDiscount : IValueCalculator
    {
        private readonly decimal _discount;

        public CalculatorWithDiscount(decimal discount)
        {
            _discount = discount;
        }
        public decimal ValueProducts(List<Product> products)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return  decimal.Subtract(sumOfProduct,(sumOfProduct*_discount*0.01m));
        }
    }
}
