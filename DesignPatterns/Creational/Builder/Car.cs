namespace DesignPatterns.Creational.Builder
{
    public class Car
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Name}: {Color} - {Model}");
        }
    }
}
