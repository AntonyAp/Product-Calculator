using System.Collections.Generic;

namespace ShopModel
{
    public class CalculatorReducingCost : IValueCalculator
    {
        private readonly decimal _sizeOfReduce;
        public CalculatorReducingCost(decimal sizeOfReduce)
        {
            _sizeOfReduce = sizeOfReduce;
        }
        public decimal ValueProducts(List<Product> products)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return decimal.Divide(sumOfProduct, _sizeOfReduce);
        }
    }
}
