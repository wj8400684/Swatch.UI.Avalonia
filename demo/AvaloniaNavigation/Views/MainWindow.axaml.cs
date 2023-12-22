using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using SwatchAvalonia.AppWindow.Controls;
using SwatchAvalonia.Navigation.Controls;

namespace AvaloniaNavigation.Views;

public partial class MainWindow : AppWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void NavView_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        this.BeginMoveDrag(e);
    }
}