namespace ShopModel
{
    public  class SimpleCalculatorFactory : ICalculatorFactory
    {
        public IValueCalculator GetCalculator()
        {
            return new SimpleCalculator();
        }
    }
}
