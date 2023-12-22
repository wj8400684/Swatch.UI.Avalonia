using Avalonia;
using Avalonia.Media;
using Avalonia.Media.Fonts;

namespace SwatchAvalonia.HarmonyOS.Fonts;

public static class AvaloniaAppBuilderExtensions
{
    public static AppBuilder UseFontHarmonyOS(this AppBuilder builder)
    {
        return builder.ConfigureFonts(fontManager =>
        {
            fontManager.AddFontCollection(new HarmonyOSFontCollection());
        });  
    }
}