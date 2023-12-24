using System;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Input;

namespace SwatchAvalonia.AppWindow.Controls;

public class AppWindow : Window
{
    protected override Type StyleKeyOverride { get; } = typeof(AppWindow);

    public AppWindow()
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
}