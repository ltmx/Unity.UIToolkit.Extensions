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
    public static T MarginTop<T>   (this T e, float value) where T : VisualElement => (e.style.marginTop = value, e).Item2;
    public static T MarginRight<T> (this T e, float value) where T : VisualElement => (e.style.marginRight = value, e).Item2;
    public static T MarginBottom<T>(this T e, float value) where T : VisualElement => (e.style.marginBottom = value, e).Item2;
    public static T MarginLeft<T>  (this T e, float value) where T : VisualElement => (e.style.marginLeft = value, e).Item2;
    
    // Padding
    public static T PaddingTop<T>  (this T e, float value) where T : VisualElement => (e.style.paddingTop = value, e).Item2;
    public static T PaddingRight<T>(this T e, float value) where T : VisualElement => (e.style.paddingRight = value, e).Item2;
    public static T PaddingBottom<T>(this T e, float value) where T : VisualElement => (e.style.paddingBottom = value, e).Item2;
    public static T PaddingLeft<T> (this T e, float value) where T : VisualElement => (e.style.paddingLeft = value, e).Item2;
    
    // Border width
    public static T BorderTopWidth<T>   (this T e, float value) where T : VisualElement => (e.style.borderTopWidth = value, e).Item2;
    public static T BorderRightWidth<T> (this T e, float value) where T : VisualElement => (e.style.borderRightWidth = value, e).Item2;
    public static T BorderBottomWidth<T>(this T e, float value) where T : VisualElement => (e.style.borderBottomWidth = value, e).Item2;
    public static T BorderLeftWidth<T>  (this T e, float value) where T : VisualElement => (e.style.borderLeftWidth = value, e).Item2;
   
    //Border width
    public static T BorderWidth<T>(this T e, float value) where T : VisualElement => (e.style.borderBottomWidth = value, e.style.borderLeftWidth = value, e.style.borderRightWidth = value, e.style.borderTopWidth = value, e).Item5;
    public static T BorderWidth<T>(this T e, float left, float right, float top, float bottom) where T : VisualElement => (e.style.borderBottomWidth = bottom, e.style.borderLeftWidth = left, e.style.borderRightWidth = right, e.style.borderTopWidth = top, e).Item5;
    
    //border radius
    public static T BorderRadius<T>(this T e, float value) where T : VisualElement => (e.style.borderBottomLeftRadius = value, e.style.borderBottomRightRadius = value, e.style.borderTopLeftRadius = value, e.style.borderTopRightRadius = value, e).Item5;
    public static T BorderRadius<T>(this T e, float bottomLeft, float bottomRight, float topLeft, float topRight) where T : VisualElement => (e.style.borderBottomLeftRadius = bottomLeft, e.style.borderBottomRightRadius = bottomRight, e.style.borderTopLeftRadius = topLeft, e.style.borderTopRightRadius = topRight, e).Item5;
   
    // Border color
    public static T BorderTopColor<T>   (this T e, Color value) where T : VisualElement => (e.style.borderTopColor = value, e).Item2;
    public static T BorderRightColor<T> (this T e, Color value) where T : VisualElement => (e.style.borderRightColor = value, e).Item2;
    public static T BorderBottomColor<T>(this T e, Color value) where T : VisualElement => (e.style.borderBottomColor = value, e).Item2;
    public static T BorderLeftColor<T>  (this T e, Color value) where T : VisualElement => (e.style.borderLeftColor = value, e).Item2;
   
    // Border Color
    public static T BorderColor<T>(this T e, Color value) where T : VisualElement => (e.style.borderBottomColor = value, e.style.borderLeftColor = value, e.style.borderRightColor = value, e.style.borderTopColor = value, e).Item5;
    public static T BorderColor<T>(this T e, Color left, Color right, Color top, Color bottom) where T : VisualElement => (e.style.borderBottomColor = bottom, e.style.borderLeftColor = left, e.style.borderRightColor = right, e.style.borderTopColor = top, e).Item5;
   
    // Background color
    public static T BackgroundColor<T>(this T e, Color value) where T : VisualElement => (e.style.backgroundColor = value, e).Item2;

    /// Compute the max radius of the element to get round corners
    // public static float ComputeMaxRadius(this VisualElement e)
    // {
    //     return e.GetMinHeight() / 2;
    //     var minSize = math.min(e.GetMinWidth(), e.GetMinHeight());
    //     var computedMin = math.min(e.GetWidth() + e.GetHorizontalPadding() + e.GetHorizontalBorderWidth(), +e.GetHeight() + e.GetVerticalPadding() + e.GetVerticalMargin());
    //     return math.max(minSize, computedMin) / 2;
    // }

    public static float GetWidth(this VisualElement e) => e.style.width.value.value;
    public static float GetHeight(this VisualElement e) => e.style.height.value.value;
    public static float GetMinWidth(this VisualElement e) => e.style.minWidth.value.value;
    public static float GetMinHeight(this VisualElement e) => e.style.minHeight.value.value;
    public static float GetMaxHeight(this VisualElement e) => e.style.maxHeight.value.value;
    public static float GetMaxWidth(this VisualElement e) => e.style.maxWidth.value.value;
    
    public static float GetTopBorderWidth(this VisualElement e) => e.style.borderTopWidth.value;
    public static float GetBottomBorderWidth(this VisualElement e) => e.style.borderBottomWidth.value;
    public static float GetLeftBorderWidth(this VisualElement e) => e.style.borderLeftWidth.value;
    public static float GetRightBorderWidth(this VisualElement e) => e.style.borderRightWidth.value;
    
    public static float GetVerticalBorderWidth(this VisualElement e) => e.GetTopBorderWidth() + e.GetBottomBorderWidth();
    public static float GetHorizontalBorderWidth(this VisualElement e) => e.GetLeftBorderWidth() + e.GetRightBorderWidth();
    
    public static float GetTopPadding(this VisualElement e) => e.style.paddingTop.value.value;
    public static float GetBottomPadding(this VisualElement e) => e.style.paddingBottom.value.value;
    public static float GetLeftPadding(this VisualElement e) => e.style.paddingLeft.value.value;
    public static float GetRightPadding(this VisualElement e) => e.style.paddingRight.value.value;
    
    public static float GetVerticalPadding(this VisualElement e) => e.GetTopPadding() + e.GetBottomPadding();
    public static float GetHorizontalPadding(this VisualElement e) => e.GetLeftPadding() + e.GetRightPadding();
    
    public static float GetTopMargin(this VisualElement e) => e.style.marginTop.value.value;
    public static float GetBottomMargin(this VisualElement e) => e.style.marginBottom.value.value;
    public static float GetLeftMargin(this VisualElement e) => e.style.marginLeft.value.value;
    public static float GetRightMargin(this VisualElement e) => e.style.marginRight.value.value;
    
    public static float GetVerticalMargin(this VisualElement e) => e.GetTopMargin() + e.GetBottomMargin();
    public static float GetHorizontalMargin(this VisualElement e) => e.GetLeftMargin() + e.GetRightMargin();
    #endregion
    
    #region Flex

    // Flex
    public static T FlexGrow<T>(this T e, float value) where T : VisualElement => (e.style.flexGrow = value, e).Item2;
    public static T FlexShrink<T>(this T e, float value) where T : VisualElement => (e.style.flexShrink = value, e).Item2;
    public static T FlexShrink<T>(this T e, bool value) where T : VisualElement => (e.style.flexShrink = value ? 1 : 0, e).Item2;
    public static T FlexBasis<T>(this T e, float value) where T : VisualElement => (e.style.flexBasis = value, e).Item2;
    public static T FlexDirection<T>(this T e, FlexDirection value) where T : VisualElement => (e.style.flexDirection = value, e).Item2;
    // Flex item
    public static T Flex<T>(this T e, float grow, float shrink, float basis) where T : VisualElement => (e.style.flexGrow = grow, e.style.flexShrink = shrink, e.style.flexBasis = basis, e).Item4;
    public static T Flex<T>(this T e, float grow, float shrink) where T : VisualElement => (e.style.flexGrow = grow, e.style.flexShrink = shrink, e).Item3;
    public static T Flex<T>(this T e, float grow) where T : VisualElement => (e.style.flexGrow = grow, e).Item2;
    
    public static T Wrap<T>(this T e, Wrap value) where T : VisualElement => (e.style.flexWrap = value, e).Item2;
    // Overload of FLexWrap that allows to pass a bool instead of a Wrap enum
    public static T Wrap<T>(this T e, bool value) where T : VisualElement => (e.style.flexWrap = value? UnityEngine.UIElements.Wrap.Wrap : UnityEngine.UIElements.Wrap.NoWrap , e).Item2;
    
    #endregion
    
    #region Positioning

    // Align
    public static T AlignSelf<T>(this T e, Align value) where T : VisualElement => (e.style.alignSelf = value, e).Item2;
    public static T AlignItems<T>(this T e, Align value) where T : VisualElement => (e.style.alignItems = value, e).Item2;
    public static T AlignContent<T>(this T e, Align value) where T : VisualElement => (e.style.alignContent = value, e).Item2;
    
    // Justify
    public static T JustifyContent<T>(this T e, Justify value) where T : VisualElement => (e.style.justifyContent = value, e).Item2;
    
    // Position
    public static T Position<T>(this T e, Position value) where T : VisualElement => (e.style.position = value, e).Item2;
    public static T Top<T>(this T e, float value) where T : VisualElement => (e.style.top = value, e).Item2;
    public static T Right<T>(this T e, float value) where T : VisualElement => (e.style.right = value, e).Item2;
    public static T Bottom<T>(this T e, float value) where T : VisualElement => (e.style.bottom = value, e).Item2;
    public static T Left<T>(this T e, float value) where T : VisualElement => (e.style.left = value, e).Item2;
    
    public static T Translate<T>(this T e, float2 value) where T : VisualElement => (e.style.translate = new Translate(value.x, value.y), e).Item2;
    public static T Translate<T>(this T e, Vector2 value) where T : VisualElement => (e.style.translate = new Translate(value.x, value.y), e).Item2;
    #endregion
    
    #region Margin & Padding

    // Margin
    public static T Margin<T>(this T e, float value) where T : VisualElement => (e.style.marginLeft = value, e.style.marginRight = value, e.style.marginTop = value, e.style.marginBottom = value, e).Item5;
    public static T Margin<T>(this T e, float horizontal, float vertical) where T : VisualElement => (e.style.marginLeft = horizontal, e.style.marginRight = horizontal, e.style.marginTop = vertical, e.style.marginBottom = vertical, e).Item5;
    public static T Margin<T>(this T e, float left, float right, float top, float bottom) where T : VisualElement => (e.style.marginLeft = left, e.style.marginRight = right, e.style.marginTop = top, e.style.marginBottom = bottom, e).Item5;
    
    // Padding
    public static T Padding<T>(this T e, float value) where T : VisualElement => (e.style.paddingLeft = value, e.style.paddingRight = value, e.style.paddingTop = value, e.style.paddingBottom = value, e).Item5;
    public static T Padding<T>(this T e, float horizontal, float vertical) where T : VisualElement => (e.style.paddingLeft = horizontal, e.style.paddingRight = horizontal, e.style.paddingTop = vertical, e.style.paddingBottom = vertical, e).Item5;
    public static T Padding<T>(this T e, float left, float right, float top, float bottom) where T : VisualElement => (e.style.paddingLeft = left, e.style.paddingRight = right, e.style.paddingTop = top, e.style.paddingBottom = bottom, e).Item5;

    #endregion
    
    #region Scaling

    // Width
    public static T Width<T>(this T e, float value) where T : VisualElement => (e.style.width = value, e).Item2;
    public static T Width<T>(this T e, float value, LengthUnit unit) where T : VisualElement => (e.style.width = new Length(value, unit), e).Item2;
    public static T MinWidth<T>(this T e, float value) where T : VisualElement => (e.style.minWidth = value, e).Item2;
    public static T MaxWidth<T>(this T e, float value) where T : VisualElement => (e.style.maxWidth = value, e).Item2;
    
    // Merged MaxWidth and MaxHeight
    public static T MaxSize<T>(this T e, float value) where T : VisualElement => (e.style.maxWidth = e.style.maxHeight = value, e).Item2;
    public static T MaxSize<T>(this T e, float2 value) where T : VisualElement
    {
        
        e.style.maxWidth = value.x;
        e.style.maxHeight = value.y;
        return e;
    }

    // e.style.maxHeight = value.y, e).Item2;
    
    // Merged MinWidth and MinHeight
    public static T MinSize<T>(this T e, float value) where T : VisualElement => (e.style.minWidth = e.style.minHeight = value, e).Item2;
    // Merged Width and Height
    public static T Size<T>(this T e, float value) where T : VisualElement => (e.style.width = e.style.height = value, e).Item2;
    
    // Height
    public static T Height<T>(this T e, float value) where T : VisualElement => (e.style.height = value, e).Item2;
    public static T MinHeight<T>(this T e, float value) where T : VisualElement => (e.style.minHeight = value, e).Item2;
    public static T MaxHeight<T>(this T e, float value) where T : VisualElement => (e.style.maxHeight = value, e).Item2;
    
    // Transformations
    public static T Scale<T>(this T e, Vector2 value) where T : VisualElement => (e.style.scale = value, e).Item2;
    public static T Scale<T>(this T e, float2 value) where T : VisualElement => (e.style.scale = new StyleScale(value), e).Item2;
    public static T Rotate<T>(this T e, float value) where T : VisualElement => (e.style.rotate = new Rotate(new Angle(value)), e).Item2;

    #endregion
    
    
    public static T Overflow<T>(this T e, Overflow value) where T : VisualElement => (e.style.overflow = value, e).Item2;
   
    public static T Display<T>(this T e, DisplayStyle value) where T : VisualElement => (e.style.display = value, e).Item2;
    public static T Display<T>(this T e, bool value) where T : VisualElement => (e.style.display = value ? DisplayStyle.Flex : DisplayStyle.None, e).Item2;
    public static T ToggleDisplay<T>(this T e) where T : VisualElement => (e.style.display = e.style.display == DisplayStyle.None ? DisplayStyle.Flex : DisplayStyle.None, e).Item2;
    
    public static T Hide<T>(this T e) where T : VisualElement => (e.style.display = DisplayStyle.None, e).Item2;
    public static T Show<T>(this T e) where T : VisualElement => (e.style.display = DisplayStyle.Flex, e).Item2;
    
    // Visibility
    public static T Visible<T>(this T e, Visibility value) where T : VisualElement => (e.style.visibility = value, e).Item2;
    public static T Visible<T>(this T e, bool value) where T : VisualElement => (e.visible = value, e).Item2;
    
    
    // Font Options
    public static T Font<T>(this T e, Font value) where T : VisualElement => (e.style.unityFont = value, e).Item2;
    public static T FontDefinition<T>(this T e, FontDefinition value) where T : VisualElement => (e.style.unityFontDefinition = value, e).Item2;
    public static T FontDefinition<T>(this T e, FontAsset value) where T : VisualElement => (e.style.unityFontDefinition = new StyleFontDefinition(value), e).Item2;
    
    public static T FontSize<T>(this T e, int value) where T : VisualElement => (e.style.fontSize = value, e).Item2;
    public static T FontSize<T>(this T e, uint value) where T : VisualElement => (e.style.fontSize = value, e).Item2;
    public static T FontStyleAndWeight<T>(this T e, FontStyle value) where T : VisualElement => (e.style.unityFontStyleAndWeight = value, e).Item2;
   
    
    
    #region TextField

    public static T Multiline<T>(this T e, bool value) where T : TextField => (e.multiline = value, e).Item2;
    public static T MaxLength<T>(this T e, int value) where T : TextField => (e.maxLength = value, e).Item2;
    public static T IsPassword<T>(this T e, bool value) where T : TextField => (e.isPasswordField = value, e).Item2;
    public static T IsReadonly<T>(this T e, bool value) where T : TextField => (e.isReadOnly = value, e).Item2;
    public static T Placeholder<T>(this T e, string value) where T : TextField => (e.textEdition.placeholder = value, e).Item2;
    public static T HidePlaceholderOnFocus<T>(this T e, bool value) where T : TextField => (e.textEdition.hidePlaceholderOnFocus = value, e).Item2;
    
    public static T MaskChar<T>(this T e, char value) where T : TextField => (e.maskChar = value, e).Item2;
    

    #endregion
    
    public static T Focusable<T>(this T e, bool value) where T : VisualElement => (e.focusable = value, e).Item2;
    public static T DelegatesFocus<T>(this T e, bool value) where T : VisualElement => (e.delegatesFocus = value, e).Item2;
   


    public static T WhiteSpace<T>(this T e, WhiteSpace whiteSpace) where T : VisualElement => (e.style.whiteSpace = whiteSpace, e).Item2;
    //Override for lost newbies who are crawling throughout the code :)
    public static T WordWrap<T>(this T e, WhiteSpace whiteSpace) where T : VisualElement => (e.style.whiteSpace = whiteSpace, e).Item2;
    public static T TextOverflow<T>(this T e, TextOverflow textOverflow) where T : VisualElement => (e.style.textOverflow = textOverflow, e).Item2;
    public static T AlignText<T>(this T e, TextAnchor value) where T : VisualElement => (e.style.unityTextAlign = value, e).Item2;
    public static T Color<T>(this T e, Color value) where T : VisualElement => (e.style.color = value, e).Item2;
    public static T Opacity<T>(this T e, float value) where T : VisualElement => (e.style.opacity = value, e).Item2;
   
    public static T BackgroundImage<T>(this T e, Texture2D value) where T : VisualElement => (e.style.backgroundImage = value, e).Item2;
    public static T BackgroundImageTintColor<T>(this T e, Color value) where T : VisualElement => (e.style.unityBackgroundImageTintColor = value, e).Item2;
    public static T BackgroundSize<T>(this T e, BackgroundSizeType value) where T : VisualElement => (e.style.backgroundSize = new BackgroundSize(value), e).Item2;
    public static T BackgroundRepeat<T>(this T e, BackgroundRepeat value) where T : VisualElement => (e.style.backgroundRepeat = value, e).Item2;
    
    public static T Text<T>(this T e, string value) where T : TextElement => (e.text = value, e).Item2;
    public static T EnableRichText<T>(this T e, bool richTextEnabled) where T : TextElement => (e.enableRichText = richTextEnabled, e).Item2;
    public static T DisplayTooltipWhenElided<T>(this T e, bool displayTooltipWhenElided) where T : TextElement => (e.displayTooltipWhenElided = displayTooltipWhenElided, e).Item2;
    public static T ParseEscapeSequences<T>(this T e, bool parseEscapeSequences) where T : TextElement => (e.parseEscapeSequences = parseEscapeSequences, e).Item2;

    #region TextElement

    public static T IsSelectable<T>(this T e, bool value) where T : TextElement => (e.selection.isSelectable = value, e).Item2;
    public static T SelectionColor<T>(this T e, Color value) where T : TextElement => (e.selection.selectionColor = value, e).Item2;
    public static T CursorColor<T>(this T e, Color value) where T : TextElement => (e.selection.cursorColor = value, e).Item2;
    public static T CursorIndex<T>(this T e, int value) where T :  TextElement => (e.selection.cursorIndex = value, e).Item2;
    public static T SelectIndex<T>(this T e, int value) where T : TextElement => (e.selection.selectIndex = value, e).Item2;
    public static T DoubleClickSelectsWord<T>(this T e, bool value) where T : TextElement => (e.selection.doubleClickSelectsWord = value, e).Item2;
    public static T TripleClickSelectsLine<T>(this T e, bool value) where T : TextElement => (e.selection.tripleClickSelectsLine = value, e).Item2;
    public static T SelectAllOnFocus<T>(this T e, bool value) where T : TextElement => (e.selection.selectAllOnFocus = value, e).Item2;
    public static T SelectAllOnMouseUp<T>(this T e, bool value) where T : TextElement => (e.selection.selectAllOnMouseUp = value, e).Item2;
    
    #endregion
    

    #region Image

    public static Image ScaleMode(this Image e, ScaleMode value) => (e.scaleMode = value, e).Item2;
    public static Image TintColor(this Image e, Color value) => (e.tintColor = value, e).Item2;

    #endregion


    #region Common

    public static T Value<T, U>(this T e, U value) where T : INotifyValueChanged<U> => (e.value = value, e).Item2;

    public static T StyleSheet<T>(this T e, StyleSheet value) where T : VisualElement
    {
        e.styleSheets.Add(value);
        return e;
    }
    
    public static T ToolTip<T>(this T e, string value) where T : VisualElement => (e.tooltip = value, e).Item2;

    #endregion
    
    public enum Orientation
    {
        Horizontal, Vertical
    }

}

