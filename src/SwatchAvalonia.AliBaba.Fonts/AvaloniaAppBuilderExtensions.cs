using Avalonia;
using Avalonia.Media;
using Avalonia.Media.Fonts;

namespace SwatchAvalonia.AliBaba.Fonts;

public static class AvaloniaAppBuilderExtensions
{
    public static AppBuilder UseFontAliBaba(this AppBuilder builder)
    {
        var setting = new FontSettings();

        return builder.With(new FontManagerOptions
        {
            DefaultFamilyName = setting.DefaultFontFamily,
            FontFallbacks = new[]
            {
                new FontFallback
                {
                    FontFamily = new FontFamily(setting.DefaultFontFamily)
                }
            }
        }).ConfigureFonts(manager =>
            manager.AddFontCollection(new EmbeddedFontCollection(setting.Key, setting.Source)));
    }
}