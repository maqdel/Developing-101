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

            Console.WriteLine("--- DI via Constructor");
            var vgpDIA = new VideoGamePlayerDI_A(new PlaystationDI());
            vgpDIA.Play();
            vgpDIA = new VideoGamePlayerDI_A(new XboxDI());
            vgpDIA.Play();
            vgpDIA = new VideoGamePlayerDI_A(new SwitchDI());
            vgpDIA.Play();

            Console.WriteLine("--- DI via Setter");
            var vgpDIB = new VideoGamePlayerDI_B();
            vgpDIB.Console = new PlaystationDI();
            vgpDIB.Play();
            vgpDIB.Console = new SwitchDI();
            vgpDIB.Play();

            Console.WriteLine("--- DI via Method");
            var vgpDIC = new VideoGamePlayerDI_C();
            vgpDIC.Play(new XboxDI());

            Console.ReadLine();
        }
    }
}
