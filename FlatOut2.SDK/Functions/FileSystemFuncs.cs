using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.Definitions.Structs;
using Reloaded.Hooks.Definitions.X86;
using Reloaded.Memory.Pointers;
using static Reloaded.Hooks.Definitions.X86.FunctionAttribute;
using static Reloaded.Hooks.Definitions.X86.FunctionAttribute.Register;

namespace FlatOut2.SDK.Functions;

/// <summary>
/// Functions related to BFS files.
/// </summary>
public unsafe class FileSystemFuncs
{
    public static readonly IFunction<OpenFileFn> OpenFile = SDK.ReloadedHooks.CreateFunction<OpenFileFn>(0x559970);
    public static readonly IFunction<OpenFileSystemFileFn> OpenFileSystemFile = SDK.ReloadedHooks.CreateFunction<OpenFileSystemFileFn>(0x55A1D0);
    public static readonly IFunction<DoesFileExistFn> DoesFileExist = SDK.ReloadedHooks.CreateFunction<DoesFileExistFn>(0x54C610);
    public static readonly IFunction<LoadBfsListFn> LoadBfsList = SDK.ReloadedHooks.CreateFunction<LoadBfsListFn>(0x520E10);
    public static readonly IFunction<InitDecompressionForFileFn> InitDecompressionForFile = SDK.ReloadedHooks.CreateFunction<InitDecompressionForFileFn>(0x560480);

    /// <summary>
    /// Opens a file from a BFS.
    /// </summary>
    /// <param name="filePath">File path of file to be opened.</param>
    /// <param name="thisPtr">The 'this' pointer.</param>
    /// <param name="flags">Unknown flags.</param>
    [Function(CallingConventions.MicrosoftThiscall)]
    public delegate IntPtr OpenFileFn(byte* filePath, void* thisPtr, int flags);
    
    [Function(CallingConventions.MicrosoftThiscall)]
    public struct OpenFileFnPtr { public FuncPtr<BlittablePointer<byte>, BlittablePointer<byte>, int, BlittablePointer<byte>> Value; }
    
    /// <summary>
    /// Opens a file from the filesystem.
    /// This function is effectively same as <see cref="OpenFileFn"/> [returns same structure], but loads from FS instead.
    /// </summary>
    /// <param name="flags">[bl] Unknown flags.</param>
    /// <param name="filePath">[edi] File path of file to be opened.</param>
    [Function(new[] { ebx, edi }, eax, StackCleanup.Caller)]
    public delegate byte* OpenFileSystemFileFn(int flags, byte* filePath);
    
    [Function(new[] { ebx, edi }, eax, StackCleanup.Caller)]
    public struct OpenFileSystemFileFnPtr { public FuncPtr<int, BlittablePointer<byte>, BlittablePointer<byte>> Value; }
    
    /// <summary>
    /// Checks if a file exists (and sets some other state stuff).
    /// </summary>
    /// <param name="filePath">[eax] File path to check.</param>
    /// <param name="checkBfsWrapper">If negative (-1), will not check BFS files.</param>
    [Function(new[] { eax }, eax, StackCleanup.Caller)]
    public delegate byte* DoesFileExistFn(byte* filePath, byte checkBfsWrapper);
    
    [Function(new[] { eax }, eax, StackCleanup.Caller)]
    public struct DoesFileExistFnPtr { public FuncPtr<BlittablePointer<byte>, byte, BlittablePointer<byte>> Value; }
    
    /// <summary>
    /// Loads a list of BFS files specified in a text file.
    /// </summary>
    /// <param name="filePath">[eax] File path to text files specifying which BFS files to load.</param>
    [Function(new[] { esi }, eax, StackCleanup.Caller)]
    public delegate byte* LoadBfsListFn(byte* filePath);
    
    [Function(new[] { esi }, eax, StackCleanup.Caller)]
    public struct LoadBfsListFnPtr { public FuncPtr<BlittablePointer<byte>, byte, BlittablePointer<byte>> Value; }
    
    [Function(new[] { eax, edi, esi }, eax, StackCleanup.Callee)]
    public delegate byte* InitDecompressionForFileFn(int a1, int a2, int a3, int a4);
}