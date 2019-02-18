namespace ShopModel
{
    public  class SimpleCalculatorFactory : ICalculatorFactory
    {
        public IValueCalculator GetCalculatorType()
        {
            return new SimpleCalculator();
        }
    }
}
