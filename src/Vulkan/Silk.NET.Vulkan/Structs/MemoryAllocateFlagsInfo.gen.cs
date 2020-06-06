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
    public unsafe struct MemoryAllocateFlagsInfo
    {
        public MemoryAllocateFlagsInfo
        (
            StructureType sType = StructureType.MemoryAllocateFlagsInfo,
            void* pNext = default,
            MemoryAllocateFlags flags = default,
            uint deviceMask = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           DeviceMask = deviceMask;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public MemoryAllocateFlags Flags;
/// <summary></summary>
        public uint DeviceMask;
    }
}
