using System;

namespace DI
{
    public class VideoGamePlayerDI_A
    {
        private readonly IConsole console;


        public VideoGamePlayerDI_A(IConsole console)
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
