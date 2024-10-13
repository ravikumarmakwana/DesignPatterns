﻿namespace DesignPatterns.Structural.Adapter
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Playing mp3 file: {fileName}");
            }
            else if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase) ||
                     audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media type: " + audioType);
            }
        }
    }
}
