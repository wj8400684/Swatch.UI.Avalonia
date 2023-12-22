using Avalonia.Controls;
using Avalonia.Input;
using System;
using System.Runtime.InteropServices;

namespace SwatchAvalonia.AppWindow1.Controls;

public class AppWindow : Window
{
    protected override Type StyleKeyOverride => typeof(AppWindow);

    public AppWindow() : base()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            PseudoClasses.Add(":windows");
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            PseudoClasses.Add(":mac");
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            PseudoClasses.Add(":linux");
        else
        {
            //其他平台自行判断
        }
    }

    protected override void OnPointerPressed(PointerPressedEventArgs e)
    {
        base.OnPointerPressed(e);
    }
}
