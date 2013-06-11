using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libzbar.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, ForceLoad = true, Frameworks="AVFoundation, CoreVideo, CoreMedia")]
