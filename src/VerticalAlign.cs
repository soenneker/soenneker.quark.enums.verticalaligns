using Intellenum;

namespace Soenneker.Quark.Enums.VerticalAligns;

/// <summary>
/// An enumeration for Quark, representing HTML vertical-align CSS values.
/// This enum contains all valid CSS vertical-align property keyword values for use in HTML/CSS styling.
/// </summary>
[Intellenum<string>]
public partial class VerticalAlign
{
    /// <summary>
    /// Aligns the baseline of the element with the baseline of its parent.
    /// This is the default value for most elements.
    /// </summary>
    public static readonly VerticalAlign Baseline = new("baseline");

    /// <summary>
    /// Aligns the baseline of the element with the subscript-baseline of its parent.
    /// This is commonly used for subscript text elements.
    /// </summary>
    public static readonly VerticalAlign Sub = new("sub");

    /// <summary>
    /// Aligns the baseline of the element with the superscript-baseline of its parent.
    /// This is commonly used for superscript text elements.
    /// </summary>
    public static readonly VerticalAlign Super = new("super");

    /// <summary>
    /// Aligns the top of the element with the top of the parent element's font.
    /// This aligns with the top of the text, not the line box.
    /// </summary>
    public static readonly VerticalAlign TextTop = new("text-top");

    /// <summary>
    /// Aligns the bottom of the element with the bottom of the parent element's font.
    /// This aligns with the bottom of the text, not the line box.
    /// </summary>
    public static readonly VerticalAlign TextBottom = new("text-bottom");

    /// <summary>
    /// Aligns the middle of the element with the baseline plus half the x-height of the parent.
    /// This provides a good middle alignment for most text elements.
    /// </summary>
    public static readonly VerticalAlign Middle = new("middle");

    /// <summary>
    /// Aligns the top of the element and its descendants with the top of the entire line.
    /// This aligns with the top of the line box, not just the text.
    /// </summary>
    public static readonly VerticalAlign Top = new("top");

    /// <summary>
    /// Aligns the bottom of the element and its descendants with the bottom of the entire line.
    /// This aligns with the bottom of the line box, not just the text.
    /// </summary>
    public static readonly VerticalAlign Bottom = new("bottom");

    /// <summary>
    /// The element inherits the vertical-align value from its parent element.
    /// This allows the element to adopt the vertical alignment behavior of its parent.
    /// </summary>
    public static readonly VerticalAlign Inherit = new("inherit");

    /// <summary>
    /// The element resets the vertical-align property to its initial value, which is 'baseline'.
    /// This effectively removes any custom vertical alignment and returns to the default state.
    /// </summary>
    public static readonly VerticalAlign Initial = new("initial");

    /// <summary>
    /// The element resets the vertical-align property to the value established by the user agent's default stylesheet.
    /// This reverts to the browser's default vertical alignment behavior.
    /// </summary>
    public static readonly VerticalAlign Revert = new("revert");

    /// <summary>
    /// The element resets the vertical-align property to the value established by the user agent's default stylesheet for the current element.
    /// This reverts to the browser's default vertical alignment behavior for this specific element type.
    /// </summary>
    public static readonly VerticalAlign RevertLayer = new("revert-layer");

    /// <summary>
    /// The element resets the vertical-align property to its inherited value if it inherits, or to its initial value if it doesn't.
    /// This provides a way to reset the vertical-align property without explicitly knowing its initial value.
    /// </summary>
    public static readonly VerticalAlign Unset = new("unset");
}
