namespace DesignPatterns.Structural.Facade
{
    public class Lights
    {
        public void Dim(int level)
        {
            Console.WriteLine($"Lights dimmed to {level}%.");
        }
        public void Off()
        {
            Console.WriteLine("Lights are Off.");
        }
    }
}
