using System;
using Avalonia.Media.Fonts;

namespace SwatchAvalonia.HarmonyOS.Fonts;

internal sealed class HarmonyOSFontCollection() : EmbeddedFontCollection(new Uri("fonts:#HarmonyOS Sans", UriKind.Absolute),
    new Uri("avares://SwatchAvalonia.HarmonyOS.Fonts/Assets", UriKind.Absolute));