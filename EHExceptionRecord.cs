﻿using Microsoft.VisualC;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size=0x20), DebugInfoInPDB, MiscellaneousBits(0x41), NativeCppClass]
internal struct EHExceptionRecord
{
    [StructLayout(LayoutKind.Sequential, Size=12), CLSCompliant(false), NativeCppClass, MiscellaneousBits(0x41), DebugInfoInPDB]
    public struct EHParameters
    {
    }
}

