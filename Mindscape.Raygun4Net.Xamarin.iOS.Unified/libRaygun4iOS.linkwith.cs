using System;
using ObjCRuntime;

[assembly: LinkWith ("libRaygun4iOS.a", LinkTarget.ArmV7s | LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Arm64, ForceLoad = true)]
