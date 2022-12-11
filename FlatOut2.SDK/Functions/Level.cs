using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.X86;

namespace FlatOut2.SDK.Functions;

/// <summary>
/// Various stage related functions.
/// </summary>
public static class Level
{
    /// <summary>
    /// Allocates memory in the game's managed heap.
    /// </summary>
    public static readonly IFunction<GetLevelNameFn> GetLevelName = SDK.ReloadedHooks.CreateFunction<GetLevelNameFn>(0x462020);
    
    /// <summary>
    /// Gets the name of the level from game memory.
    /// </summary>
    /// <param name="levelId">ID of the level being played.</param>
    /// <returns>Pointer to wide string containing level name.</returns>
    [Function(CallingConventions.Stdcall)]
    public delegate IntPtr GetLevelNameFn(int levelId);
}