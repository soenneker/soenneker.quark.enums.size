using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Semantic size tokens for Quark that align with Tailwind-style size scales.
/// </summary>
[EnumValue<string>]
public partial class SizeType
{
    /// <summary>
    /// Default size.
    /// Default semantic size token.
    /// </summary>
    public static readonly SizeType Default = new(""); 

    /// <summary>
    /// Extra small size. 
    /// Extra small semantic size token.
    /// </summary>
    public static readonly SizeType ExtraSmall = new("xs");

    /// <summary>
    /// Small size.
    /// Small semantic size token.
    /// </summary>
    public static readonly SizeType Small = new("sm");

    /// <summary>
    /// Medium size.
    /// Medium semantic size token.
    /// </summary>
    public static readonly SizeType Medium = new("md");

    /// <summary>
    /// Large size.
    /// Large semantic size token.
    /// </summary>
    public static readonly SizeType Large = new("lg");

    /// <summary>
    /// Extra large size.
    /// Extra large semantic size token.
    /// </summary>
    public static readonly SizeType ExtraLarge = new("xl");

    /// <summary>
    /// Extra extra large size.
    /// 2xl semantic size token.
    /// </summary>
    public static readonly SizeType ExtraExtraLarge = new("2xl");
}
