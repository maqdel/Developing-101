using System;

namespace DI
{
    public class VideoGamePlayerDI_B
    {
        private IConsole console;

        public IConsole Console
        {
            set { console = value; }
        }

        public VideoGamePlayerDI_B()
        {

        }

        public void Play()
        {
            console.Name();
            console.Start();
        }
    }
}
