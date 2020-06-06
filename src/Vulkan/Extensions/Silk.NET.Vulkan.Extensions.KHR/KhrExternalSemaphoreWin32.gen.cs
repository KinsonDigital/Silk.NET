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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_semaphore_win32")]
    public unsafe partial class KhrExternalSemaphoreWin32 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_semaphore_win32";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle)
            => ImplGetSemaphoreWin32Handle(device, pGetWin32HandleInfo, pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr pHandle)
            => ImplGetSemaphoreWin32Handle(device, pGetWin32HandleInfo, pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreWin32HandleKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result ImportSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo)
            => ImplImportSemaphoreWin32Handle(device, pImportSemaphoreWin32HandleInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreWin32HandleKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ImportSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImportSemaphoreWin32HandleInfoKHR pImportSemaphoreWin32HandleInfo)
            => ImplImportSemaphoreWin32Handle(device, pImportSemaphoreWin32HandleInfo);

        public KhrExternalSemaphoreWin32(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

