using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ShopModel
{
    public class ShoppingCart 
    {
        private List<Product> _products;
        private readonly IValueCalculator _valueCalc;
        public ShoppingCart(IValueCalculator calculator)
        {
            _valueCalc = calculator;
        }
        public void FillShoppingCart(List<Product> products)
        {
            _products = products;
        }

        public void ClearShoppingCart()
        {
            _products = null;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void ClearShoppingCart(Product product)
        {
            _products.Remove(product);
        }
        public decimal CalculateProductTotal()
        {
            return _valueCalc.ValueProducts(_products);
        }
    }
}
