using System.Runtime.InteropServices;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X86;

namespace FlatOut2.SDK.Functions;

/// <summary>
/// GameSpy related functions.
/// </summary>
public unsafe class GameSpy
{
    // Corresponds to 
    
    /// <summary>
    /// Gets the name of the current session.
    /// Function used by <see cref="FlatOut2.SDK.Structs.LinkSessionVTable.GetSessionName"/>.
    ///
    /// It doesn't seem to work on PC version.
    /// </summary>
    public static readonly IFunction<GetSessionNameFn> GetSessionName = SDK.ReloadedHooks.CreateFunction<GetSessionNameFn>(0x517B10);
    
    [Function(CallingConventions.MicrosoftThiscall)]
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void* GetSessionNameFn(void* thisPtr);
}