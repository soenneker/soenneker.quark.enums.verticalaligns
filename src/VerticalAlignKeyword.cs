using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An enumeration for Quark, representing HTML vertical-align CSS values.
/// This enum contains all valid CSS vertical-align property keyword values for use in HTML/CSS styling.
/// </summary>
[Intellenum<string>]
public partial class VerticalAlignKeywordKeyword
{
    /// <summary>
    /// Aligns the baseline of the element with the baseline of its parent.
    /// This is the default value for most elements.
    /// </summary>
    public static readonly VerticalAlignKeyword Baseline = new("baseline");

    /// <summary>
    /// Aligns the baseline of the element with the subscript-baseline of its parent.
    /// This is commonly used for subscript text elements.
    /// </summary>
    public static readonly VerticalAlignKeyword Sub = new("sub");

    /// <summary>
    /// Aligns the baseline of the element with the superscript-baseline of its parent.
    /// This is commonly used for superscript text elements.
    /// </summary>
    public static readonly VerticalAlignKeyword Super = new("super");

    /// <summary>
    /// Aligns the top of the element with the top of the parent element's font.
    /// This aligns with the top of the text, not the line box.
    /// </summary>
    public static readonly VerticalAlignKeyword TextTop = new("text-top");

    /// <summary>
    /// Aligns the bottom of the element with the bottom of the parent element's font.
    /// This aligns with the bottom of the text, not the line box.
    /// </summary>
    public static readonly VerticalAlignKeyword TextBottom = new("text-bottom");

    /// <summary>
    /// Aligns the middle of the element with the baseline plus half the x-height of the parent.
    /// This provides a good middle alignment for most text elements.
    /// </summary>
    public static readonly VerticalAlignKeyword Middle = new("middle");

    /// <summary>
    /// Aligns the top of the element and its descendants with the top of the entire line.
    /// This aligns with the top of the line box, not just the text.
    /// </summary>
    public static readonly VerticalAlignKeyword Top = new("top");

    /// <summary>
    /// Aligns the bottom of the element and its descendants with the bottom of the entire line.
    /// This aligns with the bottom of the line box, not just the text.
    /// </summary>
    public static readonly VerticalAlignKeyword Bottom = new("bottom");

    public static implicit operator VerticalAlignKeyword(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
