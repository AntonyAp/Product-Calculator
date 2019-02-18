namespace ShopModel
{
    public  interface ICalculatorFactory
    {
        IValueCalculator GetCalculatorType();
    }
}
