namespace ShopModel
{
    public  class CalculatorWithReducedCostFactory : ICalculatorFactory
    {
        private readonly decimal _reduceSize;
        public CalculatorWithReducedCostFactory(decimal reduceSize)
        {
            _reduceSize = reduceSize;
        }
        public IValueCalculator GetCalculator()
        {
            return new CalculatorReducingCost(_reduceSize);
        }
    }
}
