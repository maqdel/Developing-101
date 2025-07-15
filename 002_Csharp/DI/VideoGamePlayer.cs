using System;

namespace DI
{
    public class VideoGamePlayer
    {
        public void Play()
        {
            var ps = new Playstation();
            ps.Name();
            ps.Start();
        }
    }
}
