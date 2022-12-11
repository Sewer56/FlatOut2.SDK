using System.Runtime.InteropServices;

namespace FlatOut2.SDK.Utilities;

/// <summary>
/// A temporary native ANSI string, use with 'using' statement.
/// </summary>
public struct TemporaryNativeString : IDisposable
{
    public IntPtr Address;

    public TemporaryNativeString(string text) => Address = Marshal.StringToHGlobalAnsi(text);
    public void Dispose() => Marshal.FreeHGlobal(Address);
}