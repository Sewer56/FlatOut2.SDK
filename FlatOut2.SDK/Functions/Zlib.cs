using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Structs;
using Reloaded.Hooks.Definitions.X86;
using Reloaded.Memory.Pointers;
using Reloaded.Universal.Redirector.Structures;

namespace FlatOut2.SDK.Functions;

public unsafe class Zlib
{
    /// <summary>
    /// The zlib 'inflate' function.
    /// </summary>
    public static readonly IFunction<InflateFn> Inflate = SDK.ReloadedHooks.CreateFunction<InflateFn>(0x5F8000);
    
    /// <summary>
    /// Gets a table from the database.
    /// </summary>
    /// <param name="stream">The zlib stream.</param>
    /// <param name="flush">Flush option to use. FlatOut always flushes out.</param>
    /// <returns>Pointer to the table.</returns>
    [Function(CallingConventions.Cdecl)]
    public delegate ZlibReturnValue InflateFn(ZlibStream* stream, int flush);
    
    [Function(CallingConventions.Cdecl)]
    public struct InflateFnPtr { public FuncPtr<BlittablePointer<ZlibStream>, int, ZlibReturnValue> Value; }
}