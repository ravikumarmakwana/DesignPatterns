namespace DesignPatterns.Behavioral.Strategy
{
    public class ShopingCart
    {
        private IPaymentStrategy _strategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Checkout(int amount)
        {
            if (_strategy == null)
            {
                Console.WriteLine("Please register your payment strategy before checkout...");
                return;
            }
            _strategy.Pay(amount);
        }
    }
}
