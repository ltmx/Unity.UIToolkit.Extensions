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
    /// <summary>
    /// Adds USS Styling to a VisualElement
    /// <li>ShortCut for VisualElement.AddToClassList(...)</li>
    /// </summary>
    /// <returns>the VisualElement</returns>
    /// <seealso cref="VisualElement.AddToClassList"/>
    public static T USS<T>(this T e, string A) where T : VisualElement {
        e.AddToClassList(A);
        return e;
    }
    /// <inheritdoc cref="USS{T}(T,string)"/>
    public static T USS<T>(this T e, string A, string B) where T : VisualElement {
        e.AddToClassList(A);
        e.AddToClassList(B);
        return e;
    }
    /// <inheritdoc cref="USS{T}(T,string)"/>
    public static T USS<T>(this T e, string A, string B, string C) where T : VisualElement {
        e.AddToClassList(A);
        e.AddToClassList(B);
        e.AddToClassList(C);
        return e;
    }
    /// <inheritdoc cref="USS{T}(T,string)"/>
    public static T USS<T>(this T e, string A, string B, string C, string D) where T : VisualElement {
        e.AddToClassList(A);
        e.AddToClassList(B);
        e.AddToClassList(C);
        e.AddToClassList(D);
        return e;
    }

    /// <summary>
    /// Returns a list of elements having a specific USS class
    /// </summary>
    public static IEnumerable<VisualElement> WhereClassListContains(this IEnumerable<VisualElement> e, string A)
    {
        return e.Where(x => x.ClassListContains(A));
    }
    
    /// <summary>
    /// Returns a list of elements not having a specific USS class
    /// </summary>
    public static IEnumerable<VisualElement> WhereClassListMisses(this IEnumerable<VisualElement> e, string A)
    {
        return e.Where(x => x.ClassListContains(A) == false);
    }
    /// <summary>
    /// Returns a list of child elements having a specific USS class
    /// </summary>
    public static IEnumerable<VisualElement> ChildrenWithClass(this VisualElement e, string A)
    {
        return e.Children().Where(x => x.ClassListContains(A));
    }
    /// <summary>
    /// Returns the first child element having a specific USS class
    /// </summary>
    public static VisualElement FirstChildWithClass(this VisualElement e, string A)
    {
        return e.Children().FirstOrDefault(x => x.ClassListContains(A));
    }
    
    /// <summary>
    /// Returns the last child element having a specific USS class
    /// </summary>
    public static VisualElement LastChildWithClass(this VisualElement e, string A)
    {
        return e.Children().LastOrDefault(x => x.ClassListContains(A));
    }
    
    /// <summary>
    /// Adds USS Styling to every element of a IEnumerable{VisualElement}
    /// </summary>
    /// <returns>the VisualElement</returns>
    /// <seealso cref="VisualElement.AddToClassList"/>
    public static IEnumerable<T> USS<T>(this IEnumerable<T> e, string A) where T : VisualElement {
        return e.ForEachAndReturn(x => x.USS(A));
    }
    
    /// <inheritdoc cref="USS{T}(IEnumerable{T},string)"/>
    public static IEnumerable<T> USS<T>(this IEnumerable<T> e, string A, string B) where T : VisualElement {
        return e.ForEachAndReturn(x => x.USS(A, B));
    }
    /// <inheritdoc cref="USS{T}(IEnumerable{T},string)"/>
    public static IEnumerable<T> USS<T>(this IEnumerable<T> e, string A, string B, string C) where T : VisualElement {
        return e.ForEachAndReturn(x => x.USS(A, B, C));
    }
    /// <inheritdoc cref="USS{T}(IEnumerable{T},string)"/>
    public static IEnumerable<T> USS<T>(this IEnumerable<T> e, string A, string B, string C, string D) where T : VisualElement {
        return e.ForEachAndReturn(x => x.USS(A, B, C, D));
    }

    /// <summary>
    /// Removes USS Styling to a VisualElement
    /// <li>ShortCut for VisualElement.RemoveFromClassList(...)</li>
    /// </summary>
    /// <returns>the VisualElement</returns>
    /// <seealso cref="VisualElement.RemoveFromClassList"/>
    public static T RemoveUSS<T>(this T e, string A) where T : VisualElement {
        e.RemoveFromClassList(A);
        return e;
    }
    /// <inheritdoc cref="RemoveUSS{T}(T,string)"/>
    public static T RemoveUSS<T>(this T e, string A, string B) where T : VisualElement {
        e.RemoveFromClassList(A);
        e.RemoveFromClassList(B);
        return e;
    }
    /// <inheritdoc cref="RemoveUSS{T}(T,string)"/>
    public static T RemoveUSS<T>(this T e, string A, string B, string C) where T : VisualElement {
        e.RemoveFromClassList(A);
        e.RemoveFromClassList(B);
        e.RemoveFromClassList(C);
        return e;
    }
    /// <inheritdoc cref="RemoveUSS{T}(T,string)"/>
    public static T RemoveUSS<T>(this T e, string A, string B, string C, string D) where T : VisualElement {
        e.RemoveFromClassList(A);
        e.RemoveFromClassList(B);
        e.RemoveFromClassList(C);
        e.RemoveFromClassList(D);
        return e;
    }

    public static T StateUSS<T>(this T e, bool state, string A) where T : VisualElement
    {
        state.Select(e.AddToClassList, e.RemoveFromClassList, A);
        return e;
    }
    
    // 
    /// <summary>
    /// Removes USS Styling to every element of a IEnumerable{VisualElement}
    /// <li>about 8 times faster than the Linq version using the Query() method as a selector</li>
    /// </summary>
    /// <returns>the VisualElement</returns>
    /// <seealso cref="VisualElement.RemoveFromClassList"/>
    public static IEnumerable<T> RemoveUSS<T>(this IEnumerable<T> e, string A) where T : VisualElement
    {
        return e.ForEachAndReturn(x => x.RemoveFromClassList(A));
    }
    
    /// <summary>
    /// Removes all USS Styling from a given VisualElement
    /// </summary>
    public static T ClearUSS<T>(this T e) where T : VisualElement {
        e.ClearClassList();
        return e;
    }
    
    /// <summary>
    /// Removes all USS Styling from a given VisualElement and then adds a new styling
    /// </summary>
    public static T OverrideUSS<T>(this T e, string A) where T : VisualElement
    {
        return e.ClearUSS().USS(A);
    }

    /// <summary>Sets the parent container of a Given VisualElement</summary>
    /// <returns>The now parented child VisualElement</returns>
    public static T Container<T, U>(this T element, U container) where T : VisualElement where U : VisualElement
    {
        container.Add(element);
        return element;
    }
    
    /// <summary>
    /// Inserts a VisualElement Before the given element in hierarchy
    /// </summary>
    public static void InsertBefore<T>(this VisualElement v, T v2) where T : VisualElement
    {
        if (v.parent == null) {
            throw new NullReferenceException(v.name + " has no parent");
        }
        v.parent.Insert(v.parent.IndexOf(v), v2);
    }
    /// <summary>
    /// Inserts a VisualElement After the given element in hierarchy
    /// </summary>
    public static void InsertAfter<T>(this VisualElement v, T v2) where T : VisualElement
    {
        if (v.parent == null) {
            throw new NullReferenceException(v.name + " has no parent");
        }
        v.parent.Insert(v.parent.IndexOf(v) +1, v2);
    }

    /// <summary>Adds a list of VisualElements as children elements to a given VisualElement</summary>
    public static void AddMany<T>(this VisualElement v, T elements) where T : IEnumerable<VisualElement>
    {
        foreach (var e in elements)
        {
            v.Add(e);
        }
    }
}