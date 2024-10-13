namespace DesignPatterns.Structural.Adapter
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine($"Playing vlc file: {fileName}");
        }

        public void PlayMp4(string fileName)
        {
            // Do nothing
        }
    }
}
