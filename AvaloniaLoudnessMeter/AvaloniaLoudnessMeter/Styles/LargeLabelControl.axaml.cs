using Avalonia;
using Avalonia.Controls.Primitives;

namespace AvaloniaLoudnessMeter;

public class LargeLabelControl : TemplatedControl
{
    public static readonly StyledProperty<string> LargeTextProperty = AvaloniaProperty.Register<LargeLabelControl, string>(nameof(LargeText), defaultValue: "LARGE TEXT");

    public string LargeText
    { 
        get => GetValue(LargeTextProperty); 
        set => SetValue(LargeTextProperty, value); 
    }

    public static readonly StyledProperty<string> SmallTextProperty = AvaloniaProperty.Register<LargeLabelControl, string>(nameof(SmallText), defaultValue: "SMALL TEXT");

    public string SmallText
    {
        get => GetValue(SmallTextProperty);
        set => SetValue(SmallTextProperty, value);
    }
}