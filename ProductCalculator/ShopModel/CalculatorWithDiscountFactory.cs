namespace ShopModel
{
    public class CalculatorWithDiscountFactory : ICalculatorFactory
    {
        private readonly decimal _discount;
        public CalculatorWithDiscountFactory(decimal discount)
        {
            _discount = discount;
        }
        public IValueCalculator GetCalculator()
        {
            return new CalculatorWithDiscount(_discount);
        }
    }
}
