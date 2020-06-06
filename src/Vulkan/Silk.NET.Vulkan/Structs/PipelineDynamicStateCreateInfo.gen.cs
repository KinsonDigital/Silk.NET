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
    public unsafe struct PipelineDynamicStateCreateInfo
    {
        public PipelineDynamicStateCreateInfo
        (
            StructureType sType = StructureType.PipelineDynamicStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            uint dynamicStateCount = default,
            DynamicState* pDynamicStates = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           DynamicStateCount = dynamicStateCount;
           PDynamicStates = pDynamicStates;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public uint DynamicStateCount;
/// <summary></summary>
        public DynamicState* PDynamicStates;
    }
}
