using System;

namespace DI
{
    public class VideoGamePlayerDI_C
    {

        public VideoGamePlayerDI_C()
        {

        }

        public void Play(IConsole console)
        {
            console.Name();
            console.Start();
        }
    }
}
