namespace DesignPatterns.Structural.Facade
{
    public class HomeTheaterFacade
    {
        private DVDPlayer _dvdPlayer;
        private Amplifier _amplifier;
        private Projector _projector;
        private Lights _lights;

        public HomeTheaterFacade(DVDPlayer dvdPlayer, Amplifier amplifier, Projector projector, Lights lights)
        {
            _dvdPlayer = dvdPlayer;
            _amplifier = amplifier;
            _projector = projector;
            _lights = lights;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _lights.Dim(10);
            _projector.On();
            _projector.SetInput("DVD");
            _amplifier.On();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the movie theater...");
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _amplifier.Off();
            _projector.Off();
            _lights.Off();
        }
    }
}
