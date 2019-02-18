using System.Collections.Generic;

namespace ShopModel
{
    public class ShoppingCart 
    {
        private IEnumerable<Product> _products;
        private readonly IValueCalculator _valueCalc;
        public ShoppingCart(IValueCalculator calculator)
        {
            _valueCalc = calculator;
        }
        public void FillShoppingCart(IEnumerable<Product> products)
        {
            _products = products;
        }
        public decimal CalculateProductTotal()
        {
            return _valueCalc.ValueProducts(_products);
        }
    }
}
