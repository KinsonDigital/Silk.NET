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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_conditional_rendering")]
    public unsafe partial class ExtConditionalRendering : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_conditional_rendering";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBeginConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin)
            => ImplCmdBeginConditionalRendering(commandBuffer, pConditionalRenderingBegin);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBeginConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref ConditionalRenderingBeginInfoEXT pConditionalRenderingBegin)
            => ImplCmdBeginConditionalRendering(commandBuffer, pConditionalRenderingBegin);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndConditionalRenderingEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdEndConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer)
            => ImplCmdEndConditionalRendering(commandBuffer);

        public ExtConditionalRendering(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

