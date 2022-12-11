using System.Runtime.InteropServices;

namespace FlatOut2.SDK.Structs;

/// <summary>
/// Struct that contains information about various players.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct PlayerHost
{
    /// <summary>
    /// 0x674C10 in MP, 0x66D890 in SP
    /// </summary>
    [FieldOffset(0x0)]
    public void* VTable;
    
    /// <summary>
    /// Array of all player data.
    /// </summary>
    [FieldOffset(0x14)]
    public Player** Players;
    
    [FieldOffset(0x20)]
    public Player** LocalPlayer;
    
    [FieldOffset(0x2C)]
    public bool IsPaused;
    
    [FieldOffset(0x988)]
    public int NumCars;
    
    [FieldOffset(0x2086C)]
    public int LevelId;
    
    /// <summary>
    /// Total time spent since start of race.
    /// </summary>
    [FieldOffset(0x2087c)]
    public int Timer;
    
    /// <summary>
    /// Returns the timer as a TimeSpan.
    /// </summary>
    public TimeSpan TimerAsTimeSpan => TimeSpan.FromSeconds(Timer / 1000f);
}