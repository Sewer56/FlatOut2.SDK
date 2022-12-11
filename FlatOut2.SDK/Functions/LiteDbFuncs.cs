using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Structs;
using Reloaded.Hooks.Definitions.X86;

namespace FlatOut2.SDK.Functions;

/// <summary>
/// All functions related to LiteDB Tables.
/// </summary>
public unsafe class LiteDbFuncs
{
    public static readonly IFunction<GetTableFn> GetTable = SDK.ReloadedHooks.CreateFunction<GetTableFn>(0x558680);
    public static readonly IFunction<GetStringFromTableFn> GetStringFromTable = SDK.ReloadedHooks.CreateFunction<GetStringFromTableFn>(0x559270);
    
    /// <summary>
    /// Gets a table from the database.
    /// </summary>
    /// <param name="thisPtr">Pointer to 'this' instance.</param>
    /// <param name="name">Pointer to name of table element, ASCII encoding.</param>
    /// <returns>Pointer to the table.</returns>
    [Function(CallingConventions.MicrosoftThiscall)]
    public delegate IntPtr GetTableFn(IntPtr thisPtr, byte* name);
    
    [Function(CallingConventions.MicrosoftThiscall)]
    public struct GetTableFnPtr { public FuncPtr<IntPtr, IntPtr, IntPtr> Value; }
    
    /// <summary>
    /// Gets a string from a database table.
    /// </summary>
    /// <param name="thisPtr">Pointer to the 'this' property.</param>
    /// <param name="propertyName">Name of property to fetch.</param>
    /// <returns>Pointer to the property name.</returns>
    [Function(CallingConventions.MicrosoftThiscall)]
    public delegate byte* GetStringFromTableFn(IntPtr thisPtr, byte* propertyName);
    
    [Function(CallingConventions.MicrosoftThiscall)]
    public struct GetStringFromTableFnPtr { public FuncPtr<IntPtr, IntPtr, IntPtr> Value; }
}