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
    public unsafe struct PrivateDataSlotCreateInfoEXT
    {
        public PrivateDataSlotCreateInfoEXT
        (
            StructureType sType = StructureType.PrivateDataSlotCreateInfoExt,
            void* pNext = default,
            PrivateDataSlotCreateFlagsEXT flags = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PrivateDataSlotCreateFlagsEXT Flags;
    }
}
