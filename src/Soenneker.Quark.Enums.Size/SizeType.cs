using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark;

/// <summary>
/// Represents a semantic component-size token used by Quark APIs.
/// </summary>
[EnumValue<string>]
public partial class SizeType
{
    /// <summary>
    /// The default size, represented by an empty suffix.
    /// </summary>
    public static readonly SizeType Default = new("");

    /// <summary>
    /// The extra-small (<c>xs</c>) size.
    /// </summary>
    public static readonly SizeType ExtraSmall = new("xs");

    /// <summary>
    /// The small (<c>sm</c>) size.
    /// </summary>
    public static readonly SizeType Small = new("sm");

    /// <summary>
    /// The medium (<c>md</c>) size.
    /// </summary>
    public static readonly SizeType Medium = new("md");

    /// <summary>
    /// The large (<c>lg</c>) size.
    /// </summary>
    public static readonly SizeType Large = new("lg");

    /// <summary>
    /// The extra-large (<c>xl</c>) size.
    /// </summary>
    public static readonly SizeType ExtraLarge = new("xl");

    /// <summary>
    /// The extra-extra-large (<c>2xl</c>) size.
    /// </summary>
    public static readonly SizeType ExtraExtraLarge = new("2xl");
}
