using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace Soenneker.Extensions.FieldInfo;

/// <summary>
/// A collection of helpful FieldInfo (Reflection) extension methods
/// </summary>
public static class FieldInfoExtension
{
    /// <summary>
    /// Determines whether the specified field is a constant.
    /// </summary>
    /// <param name="field">The field to check.</param>
    /// <returns><c>true</c> if the field is a constant; otherwise, <c>false</c>.</returns>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsConstant(this System.Reflection.FieldInfo field)
    {
        return field.IsLiteral;
    }
}
