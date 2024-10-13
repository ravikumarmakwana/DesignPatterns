namespace DesignPatterns.Behavioral.Strategy
{
    public class CashOnDeliveryPayment : IPaymentStrategy
    {
        public void Pay(int amount)
        {
            Console.WriteLine($"Paying {amount} rupees using Cash on Delivery(COD)");
        }
    }
}
