using System.Runtime.InteropServices;
using FlatOut2.SDK.Enums;

namespace FlatOut2.SDK.Structs;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct SessionPlayer
{
    [FieldOffset(0x96)]
    public ushort NetworkId;
    
    [FieldOffset(0xC8)]
    public long QUID; // need to ask Zolika what this is
    
    [FieldOffset(0xEC)]
    public int NumReady;
    
    [FieldOffset(0x10C)]
    public int CarSkinId;
    
    [FieldOffset(0x13C)]
    public int CarId;
    
    /// <summary>
    /// If player name is shorter than 16 bytes, the name starts from here.
    /// If name is longer, this field is a pointer.
    /// </summary>
    [FieldOffset(0x160)]
    public void* PlayerNamePtrOrInline;
    
    /// <summary>
    /// Gets the player name for this structure.
    /// </summary>
    public static unsafe string GetPlayerName(SessionPlayer* sessionPlayer)
    {
        if (sessionPlayer->PlayerNameExtraData == (void*)0x0)
            return sessionPlayer->PlayerNamePtrOrInline == null ? "" : Marshal.PtrToStringUni((nint)sessionPlayer->PlayerNamePtrOrInline)!;
        
        return Marshal.PtrToStringUni((nint)(&sessionPlayer->PlayerNamePtrOrInline))!;
    }
    /// <summary>
    /// This'll be 0 if the <see cref="PlayerNamePtrOrInline"/> is a pointer.
    /// Else this contains rest of name.
    /// </summary>
    [FieldOffset(0x164)]
    public void* PlayerNameExtraData;

    [FieldOffset(0x1F4)]
    public SessionPlayerStatus PlayerStatus;
}

[StructLayout(LayoutKind.Explicit, Size = 0xC)]
public unsafe struct SessionPlayerData
{
    [FieldOffset(0x0)]
    public SessionPlayer* SessionPlayer;
    
    // Padding?
}