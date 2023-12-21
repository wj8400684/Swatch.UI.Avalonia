using System;

namespace SwatchAvalonia.AppWindow.Internals;

internal static class ReactiveExtensions
{
    public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> subAction) =>
        source.Subscribe(new SimpleObserver<T>(subAction));
}