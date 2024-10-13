namespace DesignPatterns.Behavioral.Observer
{
    public class Product : IPublisher
    {
        private readonly List<ISubscriber> _subscribers;

        public Product(string name, int price)
        {
            _subscribers = new();
            Name = name;
            _price = price;

        }

        public string Name { get; set; }
        private int _price;
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
                Notify();
            }
        }

        // other properties...

        public void Notify()
        {
            foreach (ISubscriber subscriber in _subscribers)
            {
                subscriber.Update($"The Price of the {Name}, is updated to {Price}!");
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }
    }
}
