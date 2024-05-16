using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public static partial class UIToolKitExtensions
{
    public static void TranslateToMousePositionClamped(this VisualElement e, Vector2 mousePosition)
    {
        // e.Translate(math.min(mousePosition, math.max(e.panel.visualTree.worldBound.size - e.worldBound.size, 0)));
        var translation = math.clamp(mousePosition, 0, e.panel.visualTree.worldBound.size - e.worldBound.size);
        e.Left(translation.x);
        e.Top(translation.y);
    }

    public static void RemoveOnClickOutside(this VisualElement e)
    {
        e.RegisterOnClickOutside(e.RemoveFromHierarchy);
    }
    
    public static void HideOnClickOutside(this VisualElement e)
    {
        e.RegisterOnClickOutside(() => e.Hide());
    }

    public static void RegisterOnClickOutside(this VisualElement e, Action action)
    {
        e.panel.visualTree.RegisterCallback<MouseDownEvent>(OnClickOutsideWindow);
        return;

        // local function
        void OnClickOutsideWindow(MouseDownEvent evt)
        {
            e.worldBound.Contains(evt.mousePosition).IfFalse(action.Invoke);
        }
    }
    
    public static void RegisterOnMouseLeave(this VisualElement e, Action action)
    {
        e.RegisterCallback<MouseLeaveEvent>(_ => action?.Invoke());
    }
    
    public static void HideOnMouseLeave(this VisualElement e) => e.RegisterOnMouseLeave(() => e.Hide());
    public static void RemoveOnMouseLeave(this VisualElement e) => e.RegisterOnMouseLeave(e.RemoveFromHierarchy);
}