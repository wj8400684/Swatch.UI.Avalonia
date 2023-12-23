using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SwatchAvalonia.Navigation.Media;

public class LocalizationEntry : Dictionary<string, string>
{
    public LocalizationEntry()
        : base(StringComparer.InvariantCultureIgnoreCase)
    {
    }
}

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(LocalizationEntry))]
[JsonSerializable(typeof(LocalizationMap))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}

public class LocalizationMap : Dictionary<string, LocalizationEntry>
{
    public LocalizationMap()
        : base(StringComparer.InvariantCultureIgnoreCase)
    {
    }
}