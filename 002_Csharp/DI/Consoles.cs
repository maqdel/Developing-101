using System;

namespace DI
{
  public class PlaystationDI : IConsole
  {
    public void Name()
    {
      Console.WriteLine("Playstation");
    }

    public void Start()
    {
      Console.WriteLine("Playing Playstation!!!");
    }
  }

  public class XboxDI : IConsole
  {
    public void Name()
    {
      Console.WriteLine("Xbox");
    }

    public void Start()
    {
      Console.WriteLine("Playing Xbox!!!");
    }
  }

  public class SwitchDI : IConsole
  {
    public void Name()
    {
      Console.WriteLine("witch");
    }

    public void Start()
    {
      Console.WriteLine("Playing Switch!!!");
    }
  }
}
