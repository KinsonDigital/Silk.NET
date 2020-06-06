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
    public unsafe struct CommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public CommandBufferInheritanceConditionalRenderingInfoEXT
        (
            StructureType sType = StructureType.CommandBufferInheritanceConditionalRenderingInfoExt,
            void* pNext = default,
            Bool32 conditionalRenderingEnable = default
        )
        {
           SType = sType;
           PNext = pNext;
           ConditionalRenderingEnable = conditionalRenderingEnable;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ConditionalRenderingEnable;
    }
}
