using System.Diagnostics;
using Reloaded.Hooks.Definitions;
using Reloaded.Memory.Kernel32;
using Reloaded.Memory.Sources;

namespace FlatOut2.SDK;

/// <summary>
/// Initialisation class for the SDK.
/// </summary>
public static class SDK
{
    /// <summary>
    /// Singular source of Reloaded.Hooks library.
    /// Can be replaced with shared library at runtime.
    /// </summary>
    public static IReloadedHooks ReloadedHooks { get; private set; } = null!;

    /// <summary>
    /// Initializes the Riders SDK as a Reloaded II mod, setting the shared library to be used.
    /// </summary>
    public static void Init(IReloadedHooks hooks)
    {
        ReloadedHooks = hooks;
        
        var mainModule = Process.GetCurrentProcess().MainModule;
        if (mainModule != null)
            Memory.CurrentProcess.ChangePermission((nuint)mainModule.BaseAddress, mainModule.ModuleMemorySize, Kernel32.MEM_PROTECTION.PAGE_EXECUTE_READWRITE);
    }
}