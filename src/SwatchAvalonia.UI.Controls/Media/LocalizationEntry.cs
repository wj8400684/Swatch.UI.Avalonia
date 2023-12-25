using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SwatchAvalonia.Navigation.Media;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(LocalizationEntry))]
[JsonSerializable(typeof(LocalizationMap))]
internal partial class SourceGenerationContext : JsonSerializerContext;

internal sealed class LocalizationEntry() : Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

internal sealed class LocalizationMap()
    : Dictionary<string, LocalizationEntry>(StringComparer.InvariantCultureIgnoreCase);