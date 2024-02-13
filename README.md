# Unity.UIToolkit.Extensions
Extension Library for Unity UIElements

![GitHub package.json version](https://img.shields.io/github/package-json/v/ltmx/Unity.UIToolkit.Extensions?color=blueviolet&style=for-the-badge)
![GitHub repo size](https://img.shields.io/github/repo-size/ltmx/Unity.UIToolkit.Extensions?style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/ltmx/Unity.UIToolkit.Extensions?color=success&style=for-the-badge)
![GitHub](https://img.shields.io/github/license/ltmx/Unity.UIToolkit.Extensions?style=for-the-badge)
<!--
[![openupm](https://img.shields.io/npm/v/com.ltmx.mathematics.mathx?label=openupm&style=for-the-badge&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.ltmx.mathematics.mathx)
-->

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
