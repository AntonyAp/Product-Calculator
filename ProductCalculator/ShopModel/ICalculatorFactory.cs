namespace ShopModel
{
    public  interface ICalculatorFactory
    {
        IValueCalculator GetCalculator();
    }
}
