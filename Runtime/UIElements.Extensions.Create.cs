#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System;
using UnityEngine;
using UnityEngine.UIElements;

public static partial class UIToolKitExtensions
{
    public static VisualElement VisualElement() => new();
    public static TextElement TextElement() => new();
    public static TextField TextField() => new();
    public static Button Button() => new();
    public static Label Label() => new();
    public static Image Image() => new();

    public static T Make<T>(this VisualElement container) where T : VisualElement, new() => new T().Container(container);

    public static VisualElement VisualElement(this VisualElement container) => new VisualElement().Container(container);
    public static DropdownField DropdownField(this VisualElement container) => new DropdownField().Container(container);
    public static TextElement TextElement(this VisualElement container) => new TextElement().Container(container);
    public static TextField TextField(this VisualElement container) => new TextField().Container(container);
    public static Button Button(this VisualElement container) => new Button().Container(container);
    public static Label Label(this VisualElement container) => new Label().Container(container);
    public static Image Image(this VisualElement container) => new Image().Container(container);


    public static Image Image(this VisualElement container, Texture2D texture) => new Image { image = texture }.Container(container);

    public static Label Label(this VisualElement container, string text) => new Label(text).Container(container);

    public static Button Button(this VisualElement container, Action clickEvent) => new Button(clickEvent).Container(container);

    public static Button Event(this Button button, Action clickEvent)
    {
        button.clickable = new Clickable(clickEvent);
        return button;
    }

    public static Button Button(string text, Action clickEvent) => Button().Text(text).Event(clickEvent);
    public static Button Button(Action clickEvent, string text) => Button().Text(text).Event(clickEvent);

    public static Button AddEvent(this Button button, Action clickEvent)
    {
        button.clickable.clicked += clickEvent;
        return button;
    }

    public static void Clean(this TextField textField) => textField.value = textField.value.Clean();
}