using System.Runtime.InteropServices;
using FlatOut2.SDK.Enums;

namespace FlatOut2.SDK.Structs;

/// <summary>
/// Information about the currently ongoing race.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public struct RaceInfo
{
    /// <summary>
    /// Poinnter to game's instance.
    /// </summary>
    public static readonly unsafe RaceInfo** Instance = (RaceInfo**)0x8E8410;
    
    [FieldOffset(0x458)]
    public SessionType SessionType;
    
    [FieldOffset(0x464)]
    public GameMode GameMode;
    
    [FieldOffset(0x480)]
    public int LevelId;

    [FieldOffset(0x488)]
    public int NumLaps;
    
    [FieldOffset(0x4AC)]
    public GameRules GameRules;
    
    [FieldOffset(0x9B8)]
    public unsafe PlayerHost* HostObject;
    
    [FieldOffset(0x9C8)]
    public unsafe void* MenuInterface;
    
    [FieldOffset(0xFE0)]
    public PlayerProfile PlayerProfile;
}