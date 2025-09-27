using Intellenum;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An enumeration for Quark, representing Bootstrap element sizes.
/// This enum contains the standard Bootstrap size values used throughout the framework.
/// </summary>
[Intellenum<string>]
public partial class SizeTypeType
{
    /// <summary>
    /// Default size.
    /// Bootstrap's default size (no size modifier applied).
    /// </summary>
    public static readonly SizeType Default = new(""); 

    /// <summary>
    /// Extra small size. 
    /// Bootstrap's smallest size variant.
    /// </summary>
    public static readonly SizeType ExtraSmall = new("xs");

    /// <summary>
    /// Small size.
    /// Bootstrap's small size variant.
    /// </summary>
    public static readonly SizeType Small = new("sm");

    /// <summary>
    /// Medium size.
    /// Bootstrap's medium size variant.
    /// </summary>
    public static readonly SizeType Medium = new("md");

    /// <summary>
    /// Large size.
    /// Bootstrap's large size variant.
    /// </summary>
    public static readonly SizeType Large = new("lg");

    /// <summary>
    /// Extra large size.
    /// Bootstrap's largest size variant.
    /// </summary>
    public static readonly SizeType ExtraLarge = new("xl");

    /// <summary>
    /// Extra extra large size.
    /// Bootstrap's extra large size variant for larger screens.
    /// </summary>
    public static readonly SizeType ExtraExtraLarge = new("xxl");
}
