#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using Unity.Mathematics;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;
using TextElement = UnityEngine.UIElements.TextElement;

public static partial class UIToolKitExtensions
{
    #region Common Stying

    // Margin
    /// <inheritdoc cref="IStyle.marginTop" />
    public static T MarginTop<T>(this T e, float value) where T : VisualElement => (e.style.marginTop = value, e).Item2;

    /// <inheritdoc cref="IStyle.marginRight" />
    public static T MarginRight<T>(this T e, float value) where T : VisualElement => (e.style.marginRight = value, e).Item2;

    /// <inheritdoc cref="IStyle.marginBottom" />
    public static T MarginBottom<T>(this T e, float value) where T : VisualElement => (e.style.marginBottom = value, e).Item2;

    /// <inheritdoc cref="IStyle.marginLeft" />
    public static T MarginLeft<T>(this T e, float value) where T : VisualElement => (e.style.marginLeft = value, e).Item2;

    // Padding

    /// <inheritdoc cref="IStyle.paddingTop" />
    public static T PaddingTop<T>(this T e, float value) where T : VisualElement => (e.style.paddingTop = value, e).Item2;

    /// <inheritdoc cref="IStyle.paddingRight" />
    public static T PaddingRight<T>(this T e, float value) where T : VisualElement => (e.style.paddingRight = value, e).Item2;

    /// <inheritdoc cref="IStyle.paddingBottom" />
    public static T PaddingBottom<T>(this T e, float value) where T : VisualElement => (e.style.paddingBottom = value, e).Item2;

    /// <inheritdoc cref="IStyle.paddingLeft" />
    public static T PaddingLeft<T>(this T e, float value) where T : VisualElement => (e.style.paddingLeft = value, e).Item2;

    // Border width
    /// <inheritdoc cref="IStyle.borderTopWidth" />
    public static T BorderTopWidth<T>(this T e, float value) where T : VisualElement => (e.style.borderTopWidth = value, e).Item2;

    /// <inheritdoc cref="IStyle.borderRightWidth" />
    public static T BorderRightWidth<T>(this T e, float value) where T : VisualElement => (e.style.borderRightWidth = value, e).Item2;

    /// <inheritdoc cref="IStyle.borderBottomWidth" />
    public static T BorderBottomWidth<T>(this T e, float value) where T : VisualElement => (e.style.borderBottomWidth = value, e).Item2;

    /// <inheritdoc cref="IStyle.borderLeftWidth" />
    public static T BorderLeftWidth<T>(this T e, float value) where T : VisualElement => (e.style.borderLeftWidth = value, e).Item2;

    /// <summary>Sets style.borderWidth uniformly</summary>
    public static T BorderWidth<T>(this T e, float value) where T : VisualElement => (e.style.borderBottomWidth = value, e.style.borderLeftWidth = value,
        e.style.borderRightWidth = value, e.style.borderTopWidth = value, e).Item5;

    /// <summary>Sets style.borderWidth independently</summary>
    public static T BorderWidth<T>(this T e, float left, float right, float top, float bottom) where T : VisualElement => (e.style.borderBottomWidth = bottom,
        e.style.borderLeftWidth = left, e.style.borderRightWidth = right, e.style.borderTopWidth = top, e).Item5;

    //border radius
    /// <summary>Sets style.borderRadius uniformly</summary>
    public static T BorderRadius<T>(this T e, float value) where T : VisualElement => (e.style.borderBottomLeftRadius = value, e.style.borderBottomRightRadius = value,
        e.style.borderTopLeftRadius = value, e.style.borderTopRightRadius = value, e).Item5;

    /// <summary>Sets style.borderWidth independently</summary>
    public static T BorderRadius<T>(this T e, float bottomLeft, float bottomRight, float topLeft, float topRight) where T : VisualElement => (
        e.style.borderBottomLeftRadius = bottomLeft, e.style.borderBottomRightRadius = bottomRight, e.style.borderTopLeftRadius = topLeft, e.style.borderTopRightRadius = topRight, e).Item5;

    // Border color
    /// <inheritdoc cref="IStyle.borderTopColor" />
    public static T BorderTopColor<T>(this T e, Color value) where T : VisualElement => (e.style.borderTopColor = value, e).Item2;

    /// <inheritdoc cref="IStyle.borderRightColor" />
    public static T BorderRightColor<T>(this T e, Color value) where T : VisualElement => (e.style.borderRightColor = value, e).Item2;

    /// <inheritdoc cref="IStyle.borderBottomColor" />
    public static T BorderBottomColor<T>(this T e, Color value) where T : VisualElement => (e.style.borderBottomColor = value, e).Item2;

    /// <inheritdoc cref="IStyle.borderLeftColor" />
    public static T BorderLeftColor<T>(this T e, Color value) where T : VisualElement => (e.style.borderLeftColor = value, e).Item2;

    // Border Color
    /// <summary>Sets style.borderColor uniformly</summary>
    public static T BorderColor<T>(this T e, Color value) where T : VisualElement =>
        (e.style.borderBottomColor = value, e.style.borderLeftColor = value, e.style.borderRightColor = value, e.style.borderTopColor = value, e).Item5;

    /// <summary>Sets style.borderColor independently</summary>
    public static T BorderColor<T>(this T e, Color left, Color right, Color top, Color bottom) where T : VisualElement => (e.style.borderBottomColor = bottom,
        e.style.borderLeftColor = left, e.style.borderRightColor = right, e.style.borderTopColor = top, e).Item5;

    /// <inheritdoc cref="IStyle.backgroundColor" />
    public static T BackgroundColor<T>(this T e, Color value) where T : VisualElement => (e.style.backgroundColor = value, e).Item2;

    // /// Compute the max radius of the element to get round corners
    // public static float ComputeMaxRadius(this VisualElement e)
    // {
    //     return e.GetMinHeight() / 2;
    //     var minSize = math.min(e.GetMinWidth(), e.GetMinHeight());
    //     var computedMin = math.min(e.GetWidth() + e.GetHorizontalPadding() + e.GetHorizontalBorderWidth(), +e.GetHeight() + e.GetVerticalPadding() + e.GetVerticalMargin());
    //     return math.max(minSize, computedMin) / 2;
    // }

    /// <summary>Returns style.width computed value</summary>
    public static float GetWidth(this VisualElement e) => e.style.width.value.value;

    /// <summary>Returns style.height computed value</summary>
    public static float GetHeight(this VisualElement e) => e.style.height.value.value;

    /// <summary>Returns style.minWidth computed value</summary>
    public static float GetMinWidth(this VisualElement e) => e.style.minWidth.value.value;

    /// <summary>Returns style.minHeight computed value</summary>
    public static float GetMinHeight(this VisualElement e) => e.style.minHeight.value.value;

    /// <summary>Returns style.maxHeight computed value</summary>
    public static float GetMaxHeight(this VisualElement e) => e.style.maxHeight.value.value;

    /// <summary>Returns style.maxWidth computed value</summary>
    public static float GetMaxWidth(this VisualElement e) => e.style.maxWidth.value.value;

    /// <summary>Returns style.borderTopWidth computed value</summary>
    public static float GetTopBorderWidth(this VisualElement e) => e.style.borderTopWidth.value;

    /// <summary>Returns style.borderBottomWidth computed value</summary>
    public static float GetBottomBorderWidth(this VisualElement e) => e.style.borderBottomWidth.value;

    /// <summary>Returns style.borderLeftWidth computed value</summary>
    public static float GetLeftBorderWidth(this VisualElement e) => e.style.borderLeftWidth.value;

    /// <summary>Returns style.borderRightWidth computed value</summary>
    public static float GetRightBorderWidth(this VisualElement e) => e.style.borderRightWidth.value;

    /// <summary>Returns the sum of style.borderTopWidth + style.borderBottomWidth computed values</summary>
    public static float GetVerticalBorderWidth(this VisualElement e) => e.GetTopBorderWidth() + e.GetBottomBorderWidth();

    /// <summary>Returns the sum of style.borderLeftWidth and style.borderRightWidth computed values</summary>
    public static float GetHorizontalBorderWidth(this VisualElement e) => e.GetLeftBorderWidth() + e.GetRightBorderWidth();

    /// <summary>Returns style.paddingTop computed value</summary>
    public static float GetTopPadding(this VisualElement e) => e.style.paddingTop.value.value;

    /// <summary>Returns style.paddingBottom computed value</summary>
    public static float GetBottomPadding(this VisualElement e) => e.style.paddingBottom.value.value;

    /// <summary>Returns style.paddingLeft computed value</summary>
    public static float GetLeftPadding(this VisualElement e) => e.style.paddingLeft.value.value;

    /// <summary>Returns style.paddingRight computed value</summary>
    public static float GetRightPadding(this VisualElement e) => e.style.paddingRight.value.value;

    /// <summary>Returns the sum of style.paddingTop and style.paddingBottom computed values</summary>
    public static float GetVerticalPadding(this VisualElement e) => e.GetTopPadding() + e.GetBottomPadding();

    /// <summary>Returns the sum of style.paddingLeft and style.paddingRight computed values</summary>
    public static float GetHorizontalPadding(this VisualElement e) => e.GetLeftPadding() + e.GetRightPadding();

    /// <summary>Returns style.marginTop computed value</summary>
    public static float GetTopMargin(this VisualElement e) => e.style.marginTop.value.value;

    /// <summary>Returns style.marginBottom computed value</summary>
    public static float GetBottomMargin(this VisualElement e) => e.style.marginBottom.value.value;

    /// <summary>Returns style.marginLeft computed value</summary>
    public static float GetLeftMargin(this VisualElement e) => e.style.marginLeft.value.value;

    /// <summary>Returns style.marginRight computed value</summary>
    public static float GetRightMargin(this VisualElement e) => e.style.marginRight.value.value;

    /// <summary>Returns the sum of style.marginTop and style.marginBottom computed values</summary>
    public static float GetVerticalMargin(this VisualElement e) => e.GetTopMargin() + e.GetBottomMargin();

    /// <summary>Returns the sum of style.marginLeft and style.marginRight computed values</summary>
    public static float GetHorizontalMargin(this VisualElement e) => e.GetLeftMargin() + e.GetRightMargin();

    #endregion

    #region Flex

    // Flex

    /// <inheritdoc cref="IStyle.flexGrow" />
    public static T FlexGrow<T>(this T e, float value) where T : VisualElement => (e.style.flexGrow = value, e).Item2;

    /// <inheritdoc cref="IStyle.flexShrink" />
    public static T FlexShrink<T>(this T e, float value) where T : VisualElement => (e.style.flexShrink = value, e).Item2;

    /// <inheritdoc cref="FlexShrink{T}(T,float)" />
    public static T FlexShrink<T>(this T e, bool value) where T : VisualElement => (e.style.flexShrink = value ? 1 : 0, e).Item2;

    /// <inheritdoc cref="IStyle.flexBasis" />
    public static T FlexBasis<T>(this T e, float value) where T : VisualElement => (e.style.flexBasis = value, e).Item2;

    /// <inheritdoc cref="IStyle.flexDirection" />
    public static T FlexDirection<T>(this T e, FlexDirection value) where T : VisualElement => (e.style.flexDirection = value, e).Item2;

    /// <summary>Sets all flex parameters simultaneously</summary>
    /// <seealso cref="IStyle.flexGrow" />
    /// <seealso cref="IStyle.flexShrink" />
    /// <seealso cref="IStyle.flexBasis" />
    public static T Flex<T>(this T e, float grow, float shrink, float basis) where T : VisualElement =>
        (e.style.flexGrow = grow, e.style.flexShrink = shrink, e.style.flexBasis = basis, e).Item4;

    /// <summary>Sets Simultaneously style.flexGrow and style.flexShrink</summary>
    /// <seealso cref="IStyle.flexGrow" />
    /// <seealso cref="IStyle.flexShrink" />
    public static T Flex<T>(this T e, float grow, float shrink) where T : VisualElement => (e.style.flexGrow = grow, e.style.flexShrink = shrink, e).Item3;

    /// <inheritdoc cref="IStyle.flexWrap" />
    public static T Wrap<T>(this T e, Wrap value) where T : VisualElement => (e.style.flexWrap = value, e).Item2;

    /// <inheritdoc cref="Wrap{T}(T,UnityEngine.UIElements.Wrap)" />
    public static T Wrap<T>(this T e, bool value) where T : VisualElement => (e.style.flexWrap = value ? UnityEngine.UIElements.Wrap.Wrap : UnityEngine.UIElements.Wrap.NoWrap, e).Item2;

    #endregion

    #region Positioning

    // Align

    /// <inheritdoc cref="IStyle.alignSelf" />
    public static T AlignSelf<T>(this T e, Align value) where T : VisualElement => (e.style.alignSelf = value, e).Item2;

    /// <inheritdoc cref="IStyle.alignItems" />
    public static T AlignItems<T>(this T e, Align value) where T : VisualElement => (e.style.alignItems = value, e).Item2;

    /// <inheritdoc cref="IStyle.alignContent" />
    public static T AlignContent<T>(this T e, Align value) where T : VisualElement => (e.style.alignContent = value, e).Item2;

    // Justify
    /// <inheritdoc cref="IStyle.justifyContent" />
    public static T JustifyContent<T>(this T e, Justify value) where T : VisualElement => (e.style.justifyContent = value, e).Item2;


    // Position

    /// <inheritdoc cref="IStyle.position" />
    public static T Position<T>(this T e, Position value) where T : VisualElement => (e.style.position = value, e).Item2;

    /// <inheritdoc cref="IStyle.top" />
    public static T Top<T>(this T e, float value) where T : VisualElement => (e.style.top = value, e).Item2;

    /// <inheritdoc cref="IStyle.right" />
    public static T Right<T>(this T e, float value) where T : VisualElement => (e.style.right = value, e).Item2;

    /// <inheritdoc cref="IStyle.bottom" />
    public static T Bottom<T>(this T e, float value) where T : VisualElement => (e.style.bottom = value, e).Item2;

    /// <inheritdoc cref="IStyle.left" />
    public static T Left<T>(this T e, float value) where T : VisualElement => (e.style.left = value, e).Item2;

    /// <inheritdoc cref="IStyle.translate" />
    public static T Translate<T>(this T e, float2 value) where T : VisualElement => (e.style.translate = new Translate(value.x, value.y), e).Item2;

    /// <inheritdoc cref="Translate{T}(T,Unity.Mathematics.float2)" />
    public static T Translate<T>(this T e, Vector2 value) where T : VisualElement => (e.style.translate = new Translate(value.x, value.y), e).Item2;

    #endregion

    #region Margin & Padding

    // Margin
    /// <summary>Sets margins Uniformly</summary>
    public static T Margin<T>(this T e, float value) where T : VisualElement =>
        (e.style.marginLeft = value, e.style.marginRight = value, e.style.marginTop = value, e.style.marginBottom = value, e).Item5;

    /// <summary>Sets vertical and horizontal margins</summary>
    public static T Margin<T>(this T e, float horizontal, float vertical) where T : VisualElement => (e.style.marginLeft = horizontal, e.style.marginRight = horizontal,
        e.style.marginTop = vertical, e.style.marginBottom = vertical, e).Item5;

    /// <summary>Sets margins independently</summary>
    public static T Margin<T>(this T e, float left, float right, float top, float bottom) where T : VisualElement =>
        (e.style.marginLeft = left, e.style.marginRight = right, e.style.marginTop = top, e.style.marginBottom = bottom, e).Item5;

    // Padding

    /// <summary>Sets paddings Uniformly</summary>
    public static T Padding<T>(this T e, float value) where T : VisualElement =>
        (e.style.paddingLeft = value, e.style.paddingRight = value, e.style.paddingTop = value, e.style.paddingBottom = value, e).Item5;

    /// <summary>Sets vertical and horizontal paddings</summary>
    public static T Padding<T>(this T e, float horizontal, float vertical) where T : VisualElement => (e.style.paddingLeft = horizontal, e.style.paddingRight = horizontal,
        e.style.paddingTop = vertical, e.style.paddingBottom = vertical, e).Item5;

    /// <summary>Sets paddings independently</summary>
    public static T Padding<T>(this T e, float left, float right, float top, float bottom) where T : VisualElement => (e.style.paddingLeft = left, e.style.paddingRight = right,
        e.style.paddingTop = top, e.style.paddingBottom = bottom, e).Item5;

    #endregion

    #region Scaling

    // Width

    /// <inheritdoc cref="IStyle.width" />
    public static T Width<T>(this T e, float value) where T : VisualElement => (e.style.width = value, e).Item2;

    /// <inheritdoc cref="Width{T}(T,float)" />
    public static T Width<T>(this T e, float value, LengthUnit unit) where T : VisualElement => (e.style.width = new Length(value, unit), e).Item2;

    /// <inheritdoc cref="IStyle.minWidth" />
    public static T MinWidth<T>(this T e, float value) where T : VisualElement => (e.style.minWidth = value, e).Item2;

    /// <inheritdoc cref="IStyle.maxWidth" />
    public static T MaxWidth<T>(this T e, float value) where T : VisualElement => (e.style.maxWidth = value, e).Item2;


    // Height
    /// <inheritdoc cref="IStyle.height" />
    public static T Height<T>(this T e, float value) where T : VisualElement => (e.style.height = value, e).Item2;

    /// <inheritdoc cref="IStyle.height" />
    public static T Height<T>(this T e, float value, LengthUnit unit) where T : VisualElement => (e.style.height = new Length(value, unit), e).Item2;

    /// <inheritdoc cref="IStyle.minHeight" />
    public static T MinHeight<T>(this T e, float value) where T : VisualElement => (e.style.minHeight = value, e).Item2;

    /// <inheritdoc cref="IStyle.maxHeight" />
    public static T MaxHeight<T>(this T e, float value) where T : VisualElement => (e.style.maxHeight = value, e).Item2;

    // Size

    /// <summary>Sets both style.maxWidth and style.maxHeight to the same value</summary>
    /// <seealso cref="MaxWidth{T}" />
    /// <seealso cref="MaxHeight{T}" />
    public static T MaxSize<T>(this T e, float value) where T : VisualElement => (e.style.maxWidth = e.style.maxHeight = value, e).Item2;

    /// <inheritdoc cref="MaxSize{T}(T,float)" />
    public static T MaxSize<T>(this T e, float2 value) where T : VisualElement
    {
        e.style.maxWidth = value.x;
        e.style.maxHeight = value.y;
        return e;
    }

    /// <summary>Sets both style.minWidth and style.minHeight to the same value</summary>
    /// <seealso cref="MinWidth{T}" />
    /// <seealso cref="MinHeight{T}" />
    public static T MinSize<T>(this T e, float value) where T : VisualElement => (e.style.minWidth = e.style.minHeight = value, e).Item2;

    /// <summary>Sets both style.width and style.height to the same value</summary>
    /// <seealso cref="Width{T}(T,float)" />
    /// <seealso cref="Height{T}(T,float)" />
    public static T Size<T>(this T e, float value) where T : VisualElement => (e.style.width = e.style.height = value, e).Item2;

    /// <inheritdoc cref="Size{T}(T,float)" />
    public static T Size<T>(this T e, float2 value) where T : VisualElement
    {
        e.style.width = value.x;
        e.style.height = value.y;
        return e;
    }


    // Transformations

    /// <inheritdoc cref="IStyle.scale" />
    public static T Scale<T>(this T e, Vector2 value) where T : VisualElement => (e.style.scale = value, e).Item2;

    /// <inheritdoc cref="Scale{T}(T,UnityEngine.Vector2)" />
    public static T Scale<T>(this T e, float2 value) where T : VisualElement => (e.style.scale = new StyleScale(value), e).Item2;

    /// <inheritdoc cref="IStyle.rotate" />
    public static T Rotate<T>(this T e, float value) where T : VisualElement => (e.style.rotate = new Rotate(new Angle(value)), e).Item2;

    #endregion


    #region Display and Visibility

    /// <inheritdoc cref="IStyle.display" />
    public static T Display<T>(this T e, DisplayStyle value) where T : VisualElement => (e.style.display = value, e).Item2;

    /// <inheritdoc cref="Display{T}(T,DisplayStyle)" />
    public static T Display<T>(this T e, bool value) where T : VisualElement => (e.style.display = value ? DisplayStyle.Flex : DisplayStyle.None, e).Item2;

    /// <summary>Sets style.display</summary>
    public static T ToggleDisplay<T>(this T e) where T : VisualElement => (e.style.display = e.style.display == DisplayStyle.None ? DisplayStyle.Flex : DisplayStyle.None, e).Item2;

    /// <summary>Sets style.display to false</summary>
    /// <seealso cref="IStyle.display" />
    public static T Hide<T>(this T e) where T : VisualElement => (e.style.display = DisplayStyle.None, e).Item2;

    /// <summary>Sets style.display to true</summary>
    /// <seealso cref="IStyle.display" />
    public static T Show<T>(this T e) where T : VisualElement => (e.style.display = DisplayStyle.Flex, e).Item2;


    /// <inheritdoc cref="IStyle.unityFontDefinition" />
    public static T Visible<T>(this T e, Visibility value) where T : VisualElement => (e.style.visibility = value, e).Item2;

    /// <inheritdoc cref="Visible{T}(T,Visibility)" />
    public static T Visible<T>(this T e, bool value) where T : VisualElement => (e.visible = value, e).Item2;

    #endregion


    #region Text Formatting

    /// <inheritdoc cref="IStyle.unityFont" />
    public static T Font<T>(this T e, Font value) where T : VisualElement => (e.style.unityFont = value, e).Item2;

    /// <inheritdoc cref="IStyle.unityFontDefinition" />
    public static T FontDefinition<T>(this T e, FontDefinition value) where T : VisualElement => (e.style.unityFontDefinition = value, e).Item2;

    /// <inheritdoc cref="FontDefinition{T}(T,FontDefinition)" />
    public static T FontDefinition<T>(this T e, FontAsset value) where T : VisualElement => (e.style.unityFontDefinition = new StyleFontDefinition(value), e).Item2;


    /// <inheritdoc cref="IStyle.fontSize" />
    public static T FontSize<T>(this T e, int value) where T : VisualElement => (e.style.fontSize = value, e).Item2;

    /// <inheritdoc cref="FontSize{T}(T,int)" />
    public static T FontSize<T>(this T e, uint value) where T : VisualElement => (e.style.fontSize = value, e).Item2;

    /// <inheritdoc cref="IStyle.unityFontStyleAndWeight" />
    public static T FontStyleAndWeight<T>(this T e, FontStyle value) where T : VisualElement => (e.style.unityFontStyleAndWeight = value, e).Item2;

    #endregion


    #region TextField

    /// <inheritdoc cref="TextField.multiline" />
    public static T Multiline<T>(this T e, bool value) where T : TextField => (e.multiline = value, e).Item2;

    /// <inheritdoc cref="TextField.maxLength" />
    public static T MaxLength<T>(this T e, int value) where T : TextField => (e.maxLength = value, e).Item2;

    /// <inheritdoc cref="TextField.isPasswordField" />
    public static T IsPassword<T>(this T e, bool value) where T : TextField => (e.isPasswordField = value, e).Item2;

    /// <inheritdoc cref="TextField.isReadOnly" />
    public static T IsReadonly<T>(this T e, bool value) where T : TextField => (e.isReadOnly = value, e).Item2;

    /// <inheritdoc cref="ITextEdition.placeholder" />
    public static T Placeholder<T>(this T e, string value) where T : TextField => (e.textEdition.placeholder = value, e).Item2;

    /// <inheritdoc cref="ITextEdition.hidePlaceholderOnFocus" />
    public static T HidePlaceholderOnFocus<T>(this T e, bool value) where T : TextField => (e.textEdition.hidePlaceholderOnFocus = value, e).Item2;

    /// <summary>Sets the mask character used when masking text (when isPassword is set)</summary>
    /// <see cref="TextField.maskChar" />
    public static T MaskChar<T>(this T e, char value) where T : TextField => (e.maskChar = value, e).Item2;

    #endregion

    /// <inheritdoc cref="VisualElement.focusable" />
    public static T Focusable<T>(this T e, bool value) where T : VisualElement => (e.focusable = value, e).Item2;

    /// <inheritdoc cref="VisualElement.delegatesFocus" />
    public static T DelegatesFocus<T>(this T e, bool value) where T : VisualElement => (e.delegatesFocus = value, e).Item2;

    /// <inheritdoc cref="IStyle.overflow" />
    public static T Overflow<T>(this T e, Overflow value) where T : VisualElement => (e.style.overflow = value, e).Item2;

    /// <inheritdoc cref="IStyle.whiteSpace" />
    public static T WhiteSpace<T>(this T e, WhiteSpace whiteSpace) where T : VisualElement => (e.style.whiteSpace = whiteSpace, e).Item2;

    /// <inheritdoc cref="WhiteSpace{T}" />
    public static T WordWrap<T>(this T e, WhiteSpace whiteSpace) where T : VisualElement => (e.style.whiteSpace = whiteSpace, e).Item2;

    /// <inheritdoc cref="IStyle.textOverflow" />
    public static T TextOverflow<T>(this T e, TextOverflow textOverflow) where T : VisualElement => (e.style.textOverflow = textOverflow, e).Item2;

    /// <inheritdoc cref="IStyle.unityTextAlign" />
    public static T AlignText<T>(this T e, TextAnchor value) where T : VisualElement => (e.style.unityTextAlign = value, e).Item2;

    /// <inheritdoc cref="IStyle.color" />
    public static T Color<T>(this T e, Color value) where T : VisualElement => (e.style.color = value, e).Item2;

    /// <inheritdoc cref="IStyle.opacity" />
    public static T Opacity<T>(this T e, float value) where T : VisualElement => (e.style.opacity = value, e).Item2;

    /// <inheritdoc cref="IStyle.backgroundImage" />
    public static T BackgroundImage<T>(this T e, Texture2D value) where T : VisualElement => (e.style.backgroundImage = value, e).Item2;

    /// <inheritdoc cref="IStyle.unityBackgroundImageTintColor" />
    public static T BackgroundImageTintColor<T>(this T e, Color value) where T : VisualElement => (e.style.unityBackgroundImageTintColor = value, e).Item2;

    /// <inheritdoc cref="IStyle.backgroundSize" />
    public static T BackgroundSize<T>(this T e, BackgroundSizeType value) where T : VisualElement => (e.style.backgroundSize = new BackgroundSize(value), e).Item2;

    /// <inheritdoc cref="IStyle.backgroundRepeat" />
    public static T BackgroundRepeat<T>(this T e, BackgroundRepeat value) where T : VisualElement => (e.style.backgroundRepeat = value, e).Item2;


    #region TextElement

    /// <inheritdoc cref="TextElement.text" />
    public static T Text<T>(this T e, string value) where T : TextElement => (e.text = value, e).Item2;

    /// <inheritdoc cref="TextElement.enableRichText" />
    public static T EnableRichText<T>(this T e, bool value) where T : TextElement => (e.enableRichText = value, e).Item2;

    /// <inheritdoc cref="TextElement.displayTooltipWhenElided" />
    public static T DisplayTooltipWhenElided<T>(this T e, bool displayTooltipWhenElided) where T : TextElement => (e.displayTooltipWhenElided = displayTooltipWhenElided, e).Item2;

    /// <inheritdoc cref="TextElement.parseEscapeSequences" />
    public static T ParseEscapeSequences<T>(this T e, bool parseEscapeSequences) where T : TextElement => (e.parseEscapeSequences = parseEscapeSequences, e).Item2;

    #endregion


    #region TextElement TextSelection

    /// <inheritdoc cref="ITextSelection.isSelectable" />
    /// <seealso cref="ITextSelection" />
    public static T IsSelectable<T>(this T e, bool value) where T : TextElement => (e.selection.isSelectable = value, e).Item2;

    /// <inheritdoc cref="TextElement.selectionColor" />
    /// <seealso cref="ITextSelection" />
    public static T SelectionColor<T>(this T e, Color value) where T : TextElement => (e.selection.selectionColor = value, e).Item2;

    /// <inheritdoc cref="ITextSelection.cursorColor" />
    /// <seealso cref="ITextSelection" />
    public static T CursorColor<T>(this T e, Color value) where T : TextElement => (e.selection.cursorColor = value, e).Item2;

    /// <inheritdoc cref="ITextSelection.cursorIndex" />
    /// <seealso cref="ITextSelection" />
    public static T CursorIndex<T>(this T e, int value) where T : TextElement => (e.selection.cursorIndex = value, e).Item2;

    /// <inheritdoc cref="ITextSelection.selectIndex" />
    /// <seealso cref="ITextSelection" />
    public static T SelectIndex<T>(this T e, int value) where T : TextElement => (e.selection.selectIndex = value, e).Item2;

    /// <inheritdoc cref="ITextSelection.doubleClickSelectsWord" />
    /// <seealso cref="ITextSelection" />
    public static T DoubleClickSelectsWord<T>(this T e, bool value) where T : TextElement => (e.selection.doubleClickSelectsWord = value, e).Item2;

    /// <inheritdoc cref="ITextSelection.tripleClickSelectsLine" />
    /// <seealso cref="ITextSelection" />
    public static T TripleClickSelectsLine<T>(this T e, bool value) where T : TextElement => (e.selection.tripleClickSelectsLine = value, e).Item2;

    /// <inheritdoc cref="ITextSelection.selectAllOnFocus" />
    /// <seealso cref="ITextSelection" />
    public static T SelectAllOnFocus<T>(this T e, bool value) where T : TextElement => (e.selection.selectAllOnFocus = value, e).Item2;

    /// <inheritdoc cref="ITextSelection.selectAllOnMouseUp" />
    /// <seealso cref="ITextSelection" />
    public static T SelectAllOnMouseUp<T>(this T e, bool value) where T : TextElement => (e.selection.selectAllOnMouseUp = value, e).Item2;

    #endregion


    #region Image

    /// <inheritdoc cref="Image.scaleMode" />
    public static Image ScaleMode(this Image e, ScaleMode value) => (e.scaleMode = value, e).Item2;

    /// <inheritdoc cref="Image.tintColor" />
    public static Image TintColor(this Image e, Color value) => (e.tintColor = value, e).Item2;

    #endregion


    #region Common

    /// <summary>Sets the value of a BaseField which has INotifyValueChanged callback</summary>
    /// <seealso cref="INotifyValueChanged{T}" />
    public static T Value<T, U>(this T e, U value) where T : INotifyValueChanged<U> => (e.value = value, e).Item2;

    /// <summary>Sets the StyleSheet a VisualElement should use</summary>
    /// <seealso cref="StyleSheet" />
    public static T StyleSheet<T>(this T e, StyleSheet value) where T : VisualElement
    {
        e.styleSheets.Add(value);
        return e;
    }

    /// <inheritdoc cref="VisualElement.tooltip" />
    public static T ToolTip<T>(this T e, string value) where T : VisualElement => (e.tooltip = value, e).Item2;

    #endregion

    public enum Orientation
    {
        Horizontal,
        Vertical
    }
}