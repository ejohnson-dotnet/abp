using System;
using System.Runtime.InteropServices;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// https://github.com/dotnet/aspnetcore/blob/release/9.0/src/Servers/IIS/IIS/src/NativeMethods.cs
/// </summary>
static internal partial class NativeMethods
{
    private const string KERNEL32 = "kernel32.dll";

    private const string AspNetCoreModuleDll = "aspnetcorev2_inprocess.dll";

    [LibraryImport(KERNEL32, EntryPoint = "GetModuleHandleW")]
    private static partial IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPWStr)] string lpModuleName);

    public static bool IsAspNetCoreModuleLoaded()
    {
        return GetModuleHandle(AspNetCoreModuleDll) != IntPtr.Zero;
    }
}
