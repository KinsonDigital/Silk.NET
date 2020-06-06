// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NN
{
    [Extension("VK_NN_vi_surface")]
    public unsafe partial class NNViSurface : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NN_vi_surface";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ViSurfaceCreateInfoNN* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SurfaceKHR* pSurface)
            => ImplCreateViSurface(instance, pCreateInfo, pAllocator, pSurface);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateViSurfaceNN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateViSurface([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref ViSurfaceCreateInfoNN pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SurfaceKHR pSurface)
            => ImplCreateViSurface(instance, pCreateInfo, pAllocator, pSurface);

        public NNViSurface(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

