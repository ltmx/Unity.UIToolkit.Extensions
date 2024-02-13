# Unity.UIToolkit.Extensions
Extension Methods to better build UI through code using Unity UIElements

## Create UI using LINQ Syntax
Looks :
```cs
    public static TextField CreateInputTextField(this VisualElement container)
    {
        var row = container.Row();
        row.Image().USS("logo");
        
        var inputTextField = row.TextField()
            .Multiline(true)
            .Value(AthenaSettings.DefaultPrompt)
            .ToolTip("[Shift + Enter] to SEND\n[Esc] to STOP chat")
            .Placeholder("Type your message here")
            .HidePlaceholderOnFocus(true);
        return inputTextField;
    }
```

# Install

Unity > Package Manager > Install via Git URL > paste `https://github.com/ltmx/Unity.UIToolkit.Extensions.git`

### Dependencies (automaticaly installed)
- [com.unity.mathematics](https://docs.unity3d.com/Packages/com.unity.mathematics@1.3/manual/index.html)
- [com.unity.modules.uielements](https://docs.unity3d.com/Manual/UIElements.html) (built in package)


# Examples

### Create Child Elements
```cs
element.Button();
element.TextField();
element.Label();
```

### Styling

```cs
element.USS("my-style");
element.RemoveUSS("my-class");
element.ClearUSS("my-class");
element.WhereClassListContains("my-class");
element.FirstElementWithClass("my-class");

// of course everything links together
myButton.WhereClassListContains("unity-text-element").ClearUSS();
```

## An example of how I create a Path Field

```cs
public PathField(string name) : base(name)
{
    var button = new ActionButton(OpenPathInExplorer)
        .USS("open-button")
        .FlexShrink(1)
        .FlexGrow(1)
        .AlignSelf(Align.Center)
        .Margin(0)
        .MarginRight(8)
        .Size(24)
        .BackgroundSize(BackgroundSizeType.Contain);
    Insert(1, button);
}
```
