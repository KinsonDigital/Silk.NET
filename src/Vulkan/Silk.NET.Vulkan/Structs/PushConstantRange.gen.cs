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
    public unsafe struct PushConstantRange
    {
        public PushConstantRange
        (
            ShaderStageFlags stageFlags = default,
            uint offset = default,
            uint size = default
        )
        {
           StageFlags = stageFlags;
           Offset = offset;
           Size = size;
        }

/// <summary></summary>
        public ShaderStageFlags StageFlags;
/// <summary></summary>
        public uint Offset;
/// <summary></summary>
        public uint Size;
    }
}
