using System;
using Microsoft.Extensions.Configuration;
using Sharp.Shared;

namespace Source2Surf.Timer.Shared;

// Loader shim: prevents ModSharp from failing when Timer.Shared.dll is discovered as a module assembly.
public sealed class TimerSharedModule : IModSharpModule
{
    public TimerSharedModule(ISharedSystem sharedSystem,
                             string?       dllPath,
                             string?       sharpPath,
                             Version?      version,
                             IConfiguration? coreConfiguration,
                             bool          hotReload)
    {
    }

    public string DisplayName => "Timer.Shared";

    public string DisplayAuthor => "Source2Surf";

    public bool Init() => true;

    public void Shutdown()
    {
    }
}
