using System.Runtime.InteropServices;

namespace FlatOut2.SDK.Structs;

/// <summary>
/// The database .db format used by FlatOut to store various pieces of information.
/// </summary>
public unsafe struct LiteDb
{
    /// <summary>
    /// Instance of this class.
    /// </summary>
    public static LiteDb** Instance = (LiteDb**)0x8DA700;
    
    /// <summary>
    /// Virtual function table for the object.
    /// </summary>
    public LiteDbVTable VTable;
}

[StructLayout(LayoutKind.Explicit)]
public unsafe struct LiteDbVTable
{
    [FieldOffset(0x28)]
    public Functions.LiteDbFuncs.GetTableFnPtr GetTable;
    
    [FieldOffset(0xB8)]
    public Functions.LiteDbFuncs.GetStringFromTableFnPtr GetStringFromTable;
}