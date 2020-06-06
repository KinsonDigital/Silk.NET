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
    public unsafe struct BindIndexBufferIndirectCommandNV
    {
        public BindIndexBufferIndirectCommandNV
        (
            ulong bufferAddress = default,
            uint size = default,
            IndexType indexType = default
        )
        {
           BufferAddress = bufferAddress;
           Size = size;
           IndexType = indexType;
        }

/// <summary></summary>
        public ulong BufferAddress;
/// <summary></summary>
        public uint Size;
/// <summary></summary>
        public IndexType IndexType;
    }
}
