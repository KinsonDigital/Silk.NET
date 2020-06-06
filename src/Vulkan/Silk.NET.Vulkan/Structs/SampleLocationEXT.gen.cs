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
    public unsafe struct SampleLocationEXT
    {
        public SampleLocationEXT
        (
            float x = default,
            float y = default
        )
        {
           X = x;
           Y = y;
        }

/// <summary></summary>
        public float X;
/// <summary></summary>
        public float Y;
    }
}
