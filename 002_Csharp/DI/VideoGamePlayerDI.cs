using System;

namespace DI
{
    public class VideoGamePlayerDI
    {
        private readonly IConsole console;
        

        public VideoGamePlayerDI(IConsole console)
        {
            this.console = console;
        }

        public void Play()
        {
            console.Name();
            console.Start();
        }
    }
}
