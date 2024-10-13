namespace DesignPatterns.Creational.Prototype
{
    public class Product : IPrototype<Product>
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }


        // Shallow Copy - which copies the object's fields to a new instance.
        public Product Clone()
        {
            return (Product)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Product is {Name}, having Quantity of {Quantity}");
        }
    }
}
