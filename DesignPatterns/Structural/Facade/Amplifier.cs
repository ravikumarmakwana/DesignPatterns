namespace DesignPatterns.Structural.Facade
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is On.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Amplifier volume set to {level}.");
        }
        
        public void Off()
        {
            Console.WriteLine("Amplifier is Off.");
        }
    }
}
