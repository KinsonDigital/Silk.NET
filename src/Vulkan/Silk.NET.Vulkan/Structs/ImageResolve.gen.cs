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
    public unsafe struct ImageResolve
    {
        public ImageResolve
        (
            ImageSubresourceLayers srcSubresource = default,
            Offset3D srcOffset = default,
            ImageSubresourceLayers dstSubresource = default,
            Offset3D dstOffset = default,
            Extent3D extent = default
        )
        {
           SrcSubresource = srcSubresource;
           SrcOffset = srcOffset;
           DstSubresource = dstSubresource;
           DstOffset = dstOffset;
           Extent = extent;
        }

/// <summary></summary>
        public ImageSubresourceLayers SrcSubresource;
/// <summary></summary>
        public Offset3D SrcOffset;
/// <summary></summary>
        public ImageSubresourceLayers DstSubresource;
/// <summary></summary>
        public Offset3D DstOffset;
/// <summary></summary>
        public Extent3D Extent;
    }
}
