// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct ConformanceVersionKHR
    {
        public ConformanceVersionKHR
        (
            byte major = default,
            byte minor = default,
            byte subminor = default,
            byte patch = default
        )
        {
           Major = major;
           Minor = minor;
           Subminor = subminor;
           Patch = patch;
        }

/// <summary></summary>
        public byte Major;
/// <summary></summary>
        public byte Minor;
/// <summary></summary>
        public byte Subminor;
/// <summary></summary>
        public byte Patch;
    }
}
