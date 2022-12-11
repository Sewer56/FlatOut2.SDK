# FlatOut2.SDK

A collection of definitions/library for modding FlatOut 2 with [Reloaded-II](https://reloaded-project.github.io/Reloaded-II/), using .NET & C#.  

No grandiose readme here, just a personal use library. I add little features here and there as I make new mods; and of course, contributions are always welcome 😇.

## Prerequisites

If you are unfamiliar with hacking using Reloaded-II, [the Reloaded Wiki might be helpful](https://reloaded-project.github.io/Reloaded-II/DevelopmentEnvironmentSetup/).

## Getting Started

- Clone this repository/add as submodule.  
- Add this project (as existing project) to your solution (`.sln`).  
- Add project reference to `FlatOut2.SDK` in your mod.  

In your mod's entry point `Mod()`, add the following line:  
```csharp
SDK.SDK.Init(_hooks!);
```

You are now good to go.  

Note: If your Reloaded Mod Template is old, you might need to upgrade project to .NET 7 by setting `TargetFramework` as `net7.0-windows` in your `.csproj` file.  

## High Level API

High level API can be found in the `FlatOut2.SDK.API` namespace.  
Example(s):  

```csharp
var stageName = Info.Race.GetCurrentLevelName(); // e.g. Timberlands 1
var carId     = Info.Race.GetCurrentCarId(); 
var carName   = Info.Race.GetCarName(carId); // e.g. Flatmobile
var lobbyName = Info.Multiplayer.GetLobbyName(); // GameSpy lobby name.
```

Note: As this library is purely personal use, there is no guarantee of stable API.  