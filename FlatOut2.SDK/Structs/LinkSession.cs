using System.Runtime.InteropServices;

namespace FlatOut2.SDK.Structs;

/// <summary>
/// Contains details of current network session.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct LinkSession
{
    /// <summary>
    /// Single instance of this session.
    /// </summary>
    public static readonly LinkSession* Instance = (LinkSession*)0x73B018;

    /// <summary>
    /// VTable address equals this value if on GameSpy.
    /// </summary>
    public const int MultiplayerVTable = 0x677478;
    
    [FieldOffset(0x0)]
    public LinkSessionVTable* VTable;
    
    [FieldOffset(0x4)]
    public UnknownSessionStruct* SessionStruct;
    
    [FieldOffset(0x20)]
    public SessionInfo* SessionInfo;
    
    [FieldOffset(0x216C)]
    public int UnkFlags; // 1 == host
}

[StructLayout(LayoutKind.Explicit)]
public unsafe struct LinkSessionVTable
{
    [FieldOffset(0xC)]
    public void* GetSessionName;
    
    [FieldOffset(0x1C)]
    public void* StartRace;
}

[StructLayout(LayoutKind.Explicit)]
public unsafe struct UnknownSessionStruct
{
    [FieldOffset(0x0)]
    SessionPlayer* LocalPlayer1;
    
    [FieldOffset(0x4)]
    SessionPlayer* LocalPlayer2;
    
    [FieldOffset(0x8)]
    SessionPlayer* LocalPlayer3;
    
    [FieldOffset(0xC)]
    SessionPlayer* LocalPlayer4;
    
    [FieldOffset(0x10)]
    SessionInfo* SessionInfo;
}
