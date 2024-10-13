namespace DesignPatterns.Behavioral.Observer
{
    public class Customer : ISubscriber
    {
        public string Name { get; set; }
        // Other properties...

        public void Update(string message)
        {
            Console.WriteLine(Name + ":" + message);
        }
    }
}
