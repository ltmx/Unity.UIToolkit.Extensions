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
    /// <summary>Creates a new VisualElement</summary>
    public static VisualElement VisualElement() => new();

    /// <summary>Creates a new TextElement</summary>
    public static TextElement TextElement() => new();

    /// <summary>Creates a new TextField</summary>
    public static TextField TextField() => new();

    /// <summary>Creates a new Button</summary>
    public static Button Button() => new();

    /// <summary>Creates a new Label</summary>
    public static Label Label() => new();

    /// <summary>Creates a new Image</summary>
    public static Image Image() => new();

    /// <summary>Creates a new VisualElement of type T while parenting it to a container Element</summary>
    public static T Make<T>(this VisualElement container) where T : VisualElement, new() => new T().Container(container);

    /// <summary>Creates and returns new VisualElement while parenting it to a container Element</summary>
    public static VisualElement VisualElement(this VisualElement container) => new VisualElement().Container(container);

    /// <summary>Creates and returns a new DropDownField while parenting it to a container Element</summary>
    public static DropdownField DropdownField(this VisualElement container) => new DropdownField().Container(container);

    /// <summary>Creates and returns a new TextElement while parenting it to a container Element</summary>
    public static TextElement TextElement(this VisualElement container) => new TextElement().Container(container);

    /// <summary>Creates and returns a new TextField while parenting it to a container Element</summary>
    public static TextField TextField(this VisualElement container) => new TextField().Container(container);

    /// <summary>Creates and returns a new Button while parenting it to a container Element</summary>
    public static Button Button(this VisualElement container) => new Button().Container(container);

    /// <summary>Creates and returns a new Label while parenting it to a container Element</summary>
    public static Label Label(this VisualElement container) => new Label().Container(container);

    /// <summary>Creates and returns a new Image while parenting it to a container Element</summary>
    public static Image Image(this VisualElement container) => new Image().Container(container);

    /// <summary>Creates and returns a new Slider while parenting it to a container Element</summary>
    public static Slider Slider(this VisualElement container) => new Slider().Container(container);

    /// <inheritdoc cref="Slider(UnityEngine.UIElements.VisualElement)" />
    public static Slider Slider(this VisualElement container, float min, float max) => new Slider(min, max).Container(container);

    /// <inheritdoc cref="Slider(UnityEngine.UIElements.VisualElement)" />
    public static Slider Slider(this VisualElement container, float min, float max, SliderDirection dir, float value) => new Slider(min, max, dir, value).Container(container);

    /// <summary>Creates and returns a new Image while parenting it to a container Element</summary>
    public static Image Image(this VisualElement container, Texture2D texture) => new Image { image = texture }.Container(container);

    /// <summary>Creates and returns a new Label while parenting it to a container Element</summary>
    public static Label Label(this VisualElement container, string text) => new Label(text).Container(container);

    /// <summary>Creates and returns a new Button while parenting it to a container Element</summary>
    public static Button Button(this VisualElement container, Action clickEvent) => new Button(clickEvent).Container(container);

    /// <summary>Sets the onClickEvent called when clicking a button and return</summary>
    /// <returns>button</returns>
    public static Button Event(this Button button, Action clickEvent)
    {
        button.clickable = new Clickable(clickEvent);
        return button;
    }

    /// <summary>Creates and returns a new Button with given parameters</summary>
    public static Button Button(string text, Action clickEvent) => Button().Text(text).Event(clickEvent);

    /// <summary>Creates and returns a new Button with given parameters</summary>
    public static Button Button(Action clickEvent, string text) => Button().Text(text).Event(clickEvent);

    /// <summary>Adds an action to the button's onClickEvent</summary>
    /// <returns>the button</returns>
    public static Button AddEvent(this Button button, Action clickEvent)
    {
        button.clickable.clicked += clickEvent;
        return button;
    }

    /// <summary>Cleans the TextField's input field</summary>
    /// <returns>the TextField</returns>
    public static void Clean(this TextField textField) => textField.value = textField.value.Clean();

    /// <summary>Parents a child to element and returns element</summary>
    public static T With<T, U>(this T element, U child) where T : VisualElement where U : VisualElement
    {
        element.Add(child);
        return element;
    }
}