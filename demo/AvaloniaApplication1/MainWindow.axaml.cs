using Avalonia.Controls;
using Avalonia.Input;
using SwatchAvalonia.AppWindow.Controls;

namespace AvaloniaApplication1;

public partial class MainWindow : AppWindow
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnPointerPressed(object sender,PointerPressedEventArgs args)
    {
        this.BeginMoveDrag(args);
    }
}