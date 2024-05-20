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
        e.panel.visualTree.Callback(OnClickOutsideWindow);
        return;

        // local function
        void OnClickOutsideWindow(MouseDownEvent evt)
        {
            e.layout.Contains(evt.mousePosition).IfFalse(action.Invoke);
        }
    }

    public static void Callback(this VisualElement e, EventCallback<KeyDownEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<KeyUpEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<GeometryChangedEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<MouseDownEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<MouseUpEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<MouseMoveEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<MouseEnterEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<MouseLeaveEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<WheelEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<FocusOutEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<FocusInEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<BlurEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<FocusEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<AttachToPanelEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<DetachFromPanelEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<CustomStyleResolvedEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<ExecuteCommandEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<ValidateCommandEvent> action) => e.RegisterCallback(action);
    public static void Callback(this VisualElement e, EventCallback<InputEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<DragUpdatedEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<DragPerformEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<DragExitedEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<DragEnterEvent> action) => e.RegisterCallback(action);

    public static void Callback(this VisualElement e, EventCallback<ClickEvent> action) => e.RegisterCallback(action);

    public static void Callback<T>(this VisualElement e, EventCallback<ChangeEvent<T>> action) => e.RegisterCallback(action);


    public static void RegisterOnMouseLeave(this VisualElement e, Action action)
    {
        e.RegisterCallback<MouseLeaveEvent>(_ => action?.Invoke());
    }
    
    public static void HideOnMouseLeave(this VisualElement e) => e.RegisterOnMouseLeave(() => e.Hide());
    public static void RemoveOnMouseLeave(this VisualElement e) => e.RegisterOnMouseLeave(e.RemoveFromHierarchy);
    
    public static void OnEscapeKeyPressed(this VisualElement e, Action action)
    {
        e.RegisterCallback<KeyDownEvent>(evt => {
            if (evt.keyCode == KeyCode.Escape)
            {
                action.Invoke();
            }
        });
    }
    
    public static void DisplayTargetOnHover(this VisualElement e, VisualElement target)
    {
        e.RegisterCallback<MouseEnterEvent>(_ => target.Show());
        e.RegisterCallback<MouseLeaveEvent>(_ => target.Hide());
    }
    public static void MakeTargetVisibleOnHover(this VisualElement e, VisualElement target)
    {
        e.RegisterCallback<MouseEnterEvent>(_ => target.Visible(true));
        e.RegisterCallback<MouseLeaveEvent>(_ => target.Visible(false));
    }
}