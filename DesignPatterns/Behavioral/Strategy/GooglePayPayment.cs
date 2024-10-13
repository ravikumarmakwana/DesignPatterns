namespace DesignPatterns.Behavioral.Strategy
{
    public class GooglePayPayment : IPaymentStrategy
    {
        public string Email { get; set; }

        public GooglePayPayment(string email)
        {
            Email = email;
        }

        public void Pay(int amount)
        {
            Console.WriteLine($"Paying {amount} rupees using GooglePay Account: {Email}");
        }
    }
}
