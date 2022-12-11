using System.Runtime.InteropServices;

namespace FlatOut2.SDK.Structs;

/// <summary>
/// General info for the current network session.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct SessionInfo
{
    /// <summary>
    /// Data for next player.
    /// </summary>
    [FieldOffset(0x820)]
    public SessionPlayerData* PlayerData;
    
    /// <summary>
    /// Where player data for next player will be written to/allocated.
    /// </summary>
    [FieldOffset(0x824)]
    public SessionPlayerData* NextEmptyPlayerData;
    
    public int GetPlayerCount() => (int)((NextEmptyPlayerData - PlayerData) / sizeof(SessionPlayerData));
}