using System;
using Avalonia;
using SwatchAvalonia.HarmonyOS.Fonts;

namespace AvaloniaApplication1;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UseAvaloniaNative()
            .UseSkia() // skia
            //.UseWin32() window
            //.UseX11() //linux
            .UseFontHarmonyOS()
            .LogToTrace();
}