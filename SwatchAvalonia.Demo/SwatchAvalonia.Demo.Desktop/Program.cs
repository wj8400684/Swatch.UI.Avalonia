using Avalonia;
using Avalonia.ReactiveUI;
using System;

namespace SwatchAvalonia.Demo.Desktop
{
    internal sealed class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
        {
            var app = AppBuilder.Configure<App>()
                .WithInterFont()
                .LogToTrace()
                .UseReactiveUI();

            #region aot发布预发布

            //return app.UsePlatformDetect();//如果在mac使用aot发布则屏蔽
            
            app.UseSkia();
#if Linux
                    app.UseX11();
#elif OSX
            app.UseAvaloniaNative();
#elif Windows
                    app.UseWin32();
#endif

            #endregion

            return app;
        }
    }
}