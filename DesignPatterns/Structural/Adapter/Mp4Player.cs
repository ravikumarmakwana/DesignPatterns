﻿namespace DesignPatterns.Structural.Adapter
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            // Do nothing
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing mp4 file: {fileName}");
        }
    }
}
