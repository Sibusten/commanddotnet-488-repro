using CommandDotNet;

namespace commanddotnet_488_repro;

public class RootCommand : IDisposable
{
    [DefaultCommand]
    public async Task Do()
    {
        Console.WriteLine("Command started");

        await Task.Delay(1000);
        
        Console.WriteLine("Command ended");
    }


    public void Dispose()
    {
        Console.WriteLine("Disposed");
    }
}