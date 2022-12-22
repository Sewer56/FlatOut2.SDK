using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace Reloaded.Universal.Redirector.Structures;

/// <summary>
/// Represents a ZLIB stream
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 0x38)]
public unsafe struct ZlibStream
{
     /// <summary>
     /// Next input byte.
     /// </summary>
     public byte* NextIn;

     /// <summary>
     /// Available bytes at <see cref="NextIn"/>.
     /// </summary>
     public int AvailableIn;
     
     /// <summary>
     /// Total bytes at input read so far.
     /// </summary>
     public int TotalIn;
     
     /// <summary>
     /// Next output byte.
     /// </summary>
     public byte* NextOut;
     
     /// <summary>
     /// Available bytes in output buffer.
     /// </summary>
     public int AvailableOut;
     
     /// <summary>
     /// Total bytes in output buffer.
     /// </summary>
     public int TotalOut;

     /// <summary>
     /// Last error message. [Pointer to string]
     /// </summary>
     public byte* Message;

     /// <summary>
     /// State.
     /// </summary>
     public int State;
     
     /// <summary>
     /// Function used to allocate internal state.
     /// </summary>
     public byte* Alloc;
     
     /// <summary>
     /// Function used to free internal state.
     /// </summary>
     public byte* Free;
     
     /// <summary>
     /// Data passed between ZAlloc & ZFree
     /// </summary>
     public byte* Opaque;
     
     /// <summary>
     /// Best guess if ASCII or binary
     /// </summary>
     public int DataType;

     /// <summary>
     /// Adler32 value of the uncompressed data.
     /// </summary>
     public int Adler;

     /// <summary>
     /// Not used.
     /// </summary>
     public int Reserved;
}

public enum ZlibReturnValue : int
{
     Z_OK = 0,
     Z_STREAM_END = 1,
     Z_NEED_DICT = 2,
     Z_ERRNO = (-1),
     Z_STREAM_ERROR = (-2),
     Z_DATA_ERROR = (-3),
     Z_MEM_ERROR = (-4),
     Z_BUF_ERROR = (-5),
     Z_VERSION_ERROR = (-6)
}