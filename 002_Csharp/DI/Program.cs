using System;

namespace DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Without DI");
            var vgp = new VideoGamePlayer();
            vgp.Play();

            Console.WriteLine("--- With DI");
            var vgpDI = new VideoGamePlayerDI(new PlaystationDI());
            vgpDI.Play();
            vgpDI = new VideoGamePlayerDI(new XboxDI());
            vgpDI.Play();
            vgpDI = new VideoGamePlayerDI(new SwitchDI());
            vgpDI.Play();

            Console.ReadLine();
        }
    }
}
