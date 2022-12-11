using System.Runtime.InteropServices;
using FlatOut2.SDK.Enums;

namespace FlatOut2.SDK.Structs;

/*
    Sizes:
        Player: 0x6E0
        NetworkPlayer: 0x740
        AIPlayer: 0xF50
*/

[StructLayout(LayoutKind.Explicit)]
public unsafe struct Player
{
    [FieldOffset(0x0)]
    public void* VTable;
    
    [FieldOffset(0x2D0)]
    public ColorBgra BlipColour;
    
    /// <summary>
    /// Pointer to car structure.
    /// </summary>
    [FieldOffset(0x33C)]
    public void* Car;
    
    /// <summary>
    /// ID of the car.
    /// </summary>
    [FieldOffset(0x340)]
    public int CarId;
    
    /// <summary>
    /// ID of the car skin.
    /// </summary>
    [FieldOffset(0x344)]
    public int CarSkinId;
    
    [FieldOffset(0x34C)]
    public bool IsDriverFemale;
    
    [FieldOffset(0x350)]
    public int DriverSkin;
    
    [FieldOffset(0x368)]
    public int PlayerID;
    
    [FieldOffset(0x36C)]
    public PlayerControlFlags Flags;
    
    /// <summary>
    /// set to 1 when ragdolled, instantly fades out and resets car, doesnt reset if 0x4A8 is 0.
    /// </summary>
    [FieldOffset(0x380)]
    public bool DisableControlAndReset;
    
    /// <summary>
    /// Current damage (read only). 
    /// </summary>
    [FieldOffset(0x49C)]
    public float ReadOnlyDamage;

    /// <summary>
    /// Number of nudges in stunt mode.
    /// </summary>
    [FieldOffset(0x4F8)]
    public int Nudges;
    
    /// <summary>
    /// Current steering angle.
    /// </summary>
    [FieldOffset(0x684)]
    public float SteerAngle;
    
    /// <summary>
    /// Force on Gas Pedal.
    /// </summary>
    [FieldOffset(0x688)]
    public float GasPedal;
    
    /// <summary>
    /// Force on Brake Pedal.
    /// </summary>
    [FieldOffset(0x68C)]
    public float BrakePedal;
}