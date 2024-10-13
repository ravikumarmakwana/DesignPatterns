namespace DesignPatterns.Behavioral.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public string CardNumber { get; set; }

        public CreditCardPayment(string cardNumber)
        {
            CardNumber = cardNumber;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($"Paying {amount} rupees using Credit Card: {CardNumber}");
        }
    }
}
