using System;
using Avalonia.Media.Fonts;

namespace SwatchAvalonia.AliBaba.Fonts;

public sealed class AliBabaFontCollection() : EmbeddedFontCollection(
    new Uri("fonts:#Alibaba PuHuiTi 3.0", UriKind.Absolute),
    new Uri("avares://SwatchAvalonia.AliBaba.Fonts/Assets", UriKind.Absolute));