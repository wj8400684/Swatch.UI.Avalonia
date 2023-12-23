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
        NavView.ItemInvoked += OnViewOnItemInvoked;
        NavView.BackRequested += OnViewOnBackRequested;
        NavView.SelectionChanged += OnViewOnSelectionChanged;
    }

    private void OnViewOnBackRequested(object? sender, NavigationViewBackRequestedEventArgs e)
    {
    }

    private void OnViewOnSelectionChanged(object? sender, NavigationViewSelectionChangedEventArgs e)
    {
    }

    private void OnViewOnItemInvoked(object? sender, NavigationViewItemInvokedEventArgs e)
    {
    }

    private void NavView_OnPointerPressed(object? sender, PointerPressedEventArgs e)
    {
        this.BeginMoveDrag(e);
    }
}