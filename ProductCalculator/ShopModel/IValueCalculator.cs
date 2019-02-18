using System.Collections.Generic;

namespace ShopModel
{
    public interface IValueCalculator
    {
         decimal ValueProducts(List<Product> products);
    }
}
