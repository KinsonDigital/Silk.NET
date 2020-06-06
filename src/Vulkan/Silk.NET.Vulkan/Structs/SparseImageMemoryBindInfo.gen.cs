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
    public unsafe struct SparseImageMemoryBindInfo
    {
        public SparseImageMemoryBindInfo
        (
            Image image = default,
            uint bindCount = default,
            SparseImageMemoryBind* pBinds = default
        )
        {
           Image = image;
           BindCount = bindCount;
           PBinds = pBinds;
        }

/// <summary></summary>
        public Image Image;
/// <summary></summary>
        public uint BindCount;
/// <summary></summary>
        public SparseImageMemoryBind* PBinds;
    }
}
