#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UIElements;

public static partial class UIToolKitExtensions
{
    public static T USS<T>(this T e, string A) where T : VisualElement {
        e.AddToClassList(A);
        return e;
    }
    public static T USS<T>(this T e, string A, string B) where T : VisualElement {
        e.AddToClassList(A);
        e.AddToClassList(B);
        return e;
    }
    public static T USS<T>(this T e, string A, string B, string C) where T : VisualElement {
        e.AddToClassList(A);
        e.AddToClassList(B);
        e.AddToClassList(C);
        return e;
    }
    public static T USS<T>(this T e, string A, string B, string C, string D) where T : VisualElement {
        e.AddToClassList(A);
        e.AddToClassList(B);
        e.AddToClassList(C);
        e.AddToClassList(D);
        return e;
    }

    public static IEnumerable<VisualElement> WhereClassListContains(this IEnumerable<VisualElement> e, string A)
    {
        return e.Where(x => x.ClassListContains(A));
    }
    public static IEnumerable<VisualElement> WhereClassListMisses(this IEnumerable<VisualElement> e, string A)
    {
        return e.Where(x => x.ClassListContains(A) == false);
    }
    
    public static IEnumerable<VisualElement> ChildrenWithClass(this VisualElement e, string A)
    {
        return e.Children().Where(x => x.ClassListContains(A));
    }
    public static VisualElement FirstChildWithClass(this VisualElement e, string A)
    {
        return e.Children().FirstOrDefault(x => x.ClassListContains(A));
    }
    public static VisualElement LastChildWithClass(this VisualElement e, string A)
    {
        return e.Children().Last(x => x.ClassListContains(A));
    }
    
    public static IEnumerable<T> USS<T>(this IEnumerable<T> e, string A) where T : VisualElement {
        return e.ForEachAndReturn(x => x.USS(A));
    }
    public static IEnumerable<T> USS<T>(this IEnumerable<T> e, string A, string B) where T : VisualElement {
        return e.ForEachAndReturn(x => x.USS(A, B));
    }
    public static IEnumerable<T> USS<T>(this IEnumerable<T> e, string A, string B, string C) where T : VisualElement {
        return e.ForEachAndReturn(x => x.USS(A, B, C));
    }
    public static IEnumerable<T> USS<T>(this IEnumerable<T> e, string A, string B, string C, string D) where T : VisualElement {
        return e.ForEachAndReturn(x => x.USS(A, B, C, D));
    }

    public static T RemoveUSS<T>(this T e, string A) where T : VisualElement {
        e.RemoveFromClassList(A);
        return e;
    }

    public static T StateUSS<T>(this T e, bool state, string A) where T : VisualElement
    {
        state.Select(e.AddToClassList, e.RemoveFromClassList, A);
        return e;
    }
    
    // about 8 times faster than the Linq version using the Query() method as a selector
    public static IEnumerable<T> RemoveUSS<T>(this IEnumerable<T> e, string A) where T : VisualElement
    {
        return e.ForEachAndReturn(x => x.RemoveFromClassList(A));
    }
    
    public static T ClearUSS<T>(this T e) where T : VisualElement {
        e.ClearClassList();
        return e;
    }
    
    public static T OverrideUSS<T>(this T e, string A) where T : VisualElement
    {
        return e.ClearUSS().USS(A);
    }

    public static T Container<T, U>(this T element, U container) where T : VisualElement where U : VisualElement {
        container.Add(element);
        return element;
    }
    
    public static VisualElement Insert(this VisualElement v, VisualElement v2)
    {
        v.Add(v2);
        return v;
    }
    
    public static void InsertBefore(this VisualElement v, VisualElement v2)
    {
        if (v.parent == null) {
            throw new NullReferenceException(v.name + " has no parent");
        }
        v.parent.Insert(v.parent.IndexOf(v), v2);
    }
    public static void InsertAfter(this VisualElement v, VisualElement v2)
    {
        if (v.parent == null) {
            throw new NullReferenceException(v.name + " has no parent");
        }
        v.parent.Insert(v.parent.IndexOf(v) +1, v2);
    }
    
    public static void AddMany<T>(this VisualElement v, T elements) where T : IEnumerable<VisualElement>
    {
        foreach (var e in elements)
        {
            v.Add(e);
        }
    }
}