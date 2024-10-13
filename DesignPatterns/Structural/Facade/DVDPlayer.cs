namespace DesignPatterns.Structural.Facade
{
    public class DVDPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD Player is On.");
        }
        
        public void Play(string movie)
        {
            Console.WriteLine($"Playing '{movie}' on DVD Player.");
        }

        public void Stop()
        {
            Console.WriteLine("DVD Player is Stopped.");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player is Off.");
        }
    }
}
