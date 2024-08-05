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
        e.panel.visualTree.Callback(OnClickOutsideWindow, TrickleDown.TrickleDown);
        return;

        // local function
        void OnClickOutsideWindow(MouseDownEvent evt)
        {
            evt.button.Equals(0).AndNot(e.layout.Contains(evt.mousePosition)).IfTrue(action);
        }
    }

    public static void Callback(this VisualElement e, EventCallback<KeyDownEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<KeyUpEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<GeometryChangedEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<MouseDownEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<MouseUpEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<MouseMoveEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<MouseEnterEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<MouseLeaveEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<WheelEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<FocusOutEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<FocusInEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<BlurEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<FocusEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<AttachToPanelEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<DetachFromPanelEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<CustomStyleResolvedEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback(this VisualElement e, EventCallback<ExecuteCommandEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<ValidateCommandEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback(this VisualElement e, EventCallback<InputEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    
    public static void Callback(this VisualElement e, EventCallback<ClickEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);

    public static void Callback<T>(this VisualElement e, EventCallback<ChangeEvent<T>> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    public static void Callback<T>(this VisualElement e, EventCallback<T> action, TrickleDown trickleDown = TrickleDown.TrickleDown) where T : EventBase<T>, new()
        => e.RegisterCallback(action, trickleDown);
    
    // todo find why these can't be included in build
    // public static void Callback(this VisualElement e, EventCallback<DragUpdatedEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    // public static void Callback(this VisualElement e, EventCallback<DragPerformEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    // public static void Callback(this VisualElement e, EventCallback<DragExitedEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);
    // public static void Callback(this VisualElement e, EventCallback<DragEnterEvent> action, TrickleDown trickleDown = TrickleDown.TrickleDown) => e.RegisterCallback(action, trickleDown);




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
    /// <summary>
    /// The default state of the target is invisible
    /// </summary>
    public static void MakeTargetVisibleOnHover(this VisualElement e, VisualElement target)
    {
        target.visible = false;
        e.RegisterCallback<MouseEnterEvent>(_ => target.Visible(true));
        e.RegisterCallback<MouseLeaveEvent>(_ => target.Visible(false));
    }
}