namespace SwatchAvalonia.UI.Controls;

public class FrameNavigationOptions
{
    /// <summary>
    /// Gets or sets a value that indicates the animated transition associated with the navigation.
    /// </summary>
    public UITransitionInfo TransitionInfoOverride { get; set; }

    /// <summary>
    /// Gets or sets a value that indicates whether navigation is recorded in the Frame's ForwardStack or BackStack.
    /// </summary>
    public bool IsNavigationStackEnabled { get; set; }
}
