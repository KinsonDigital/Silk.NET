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
    public unsafe struct TraceRaysIndirectCommandKHR
    {
        public TraceRaysIndirectCommandKHR
        (
            uint width = default,
            uint height = default,
            uint depth = default
        )
        {
           Width = width;
           Height = height;
           Depth = depth;
        }

/// <summary></summary>
        public uint Width;
/// <summary></summary>
        public uint Height;
/// <summary></summary>
        public uint Depth;
    }
}
