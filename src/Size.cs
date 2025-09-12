using Intellenum;

namespace Soenneker.Quark.Enums.Size;

/// <summary>
/// An enumeration for Quark, representing Bootstrap element sizes.
/// This enum contains the standard Bootstrap size values used throughout the framework.
/// </summary>
[Intellenum<string>]
public partial class Size
{
    /// <summary>
    /// Default size.
    /// Bootstrap's default size (no size modifier applied).
    /// </summary>
    public static readonly Size Default = new(""); 

    /// <summary>
    /// Extra small size.
    /// Bootstrap's smallest size variant.
    /// </summary>
    public static readonly Size ExtraSmall = new("xs");

    /// <summary>
    /// Small size.
    /// Bootstrap's small size variant.
    /// </summary>
    public static readonly Size Small = new("sm");

    /// <summary>
    /// Medium size.
    /// Bootstrap's medium size variant.
    /// </summary>
    public static readonly Size Medium = new("md");

    /// <summary>
    /// Large size.
    /// Bootstrap's large size variant.
    /// </summary>
    public static readonly Size Large = new("lg");

    /// <summary>
    /// Extra large size.
    /// Bootstrap's largest size variant.
    /// </summary>
    public static readonly Size ExtraLarge = new("xl");

    /// <summary>
    /// Extra extra large size.
    /// Bootstrap's extra large size variant for larger screens.
    /// </summary>
    public static readonly Size ExtraExtraLarge = new("xxl");
}
