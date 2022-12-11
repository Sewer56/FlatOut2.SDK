using System.Runtime.InteropServices;

namespace FlatOut2.SDK.Structs;

/// <summary>
/// Struct that contains information tied to load screens.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public struct LoadScreenInfo
{
    /// <summary>
    /// Instance of this structure.
    /// </summary>
    public static readonly unsafe LoadScreenInfo** Instance = (LoadScreenInfo**)0x008E8454;

    /// <summary>
    /// Pointer to tuples of level ids and background image pointers.
    /// </summary>
    [FieldOffset(0x230)]
    public unsafe LevelbackgroundImageTuple* LevelAndBackgroundImageTuples;
    
    /// <summary>
    /// Number of items in above array.
    /// </summary>
    [FieldOffset(0x234)]
    public int NumLevelAndBackgroundImageTuples;
    
    public struct LevelbackgroundImageTuple
    {
        public unsafe void* BackgroundImagePathPtr;
        public int LevelId;

        public unsafe string BackgroundImagePath => Marshal.PtrToStringAnsi((nint)BackgroundImagePathPtr)!;
    }
}