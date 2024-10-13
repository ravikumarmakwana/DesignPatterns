namespace DesignPatterns.Structural.Facade
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is On.");
        }

        public void SetInput(string source)
        {
            Console.WriteLine($"Projector input set to {source}.");
        }
        
        public void Off()
        {
            Console.WriteLine("Projector is Off.");
        }
    }
}
