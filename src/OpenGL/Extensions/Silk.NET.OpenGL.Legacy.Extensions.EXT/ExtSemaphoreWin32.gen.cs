// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_semaphore_win32")]
    public unsafe partial class ExtSemaphoreWin32 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore_win32";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImportSemaphoreWin32Handle([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] void* handle)
            => ImplImportSemaphoreWin32Handle(semaphore, handleType, handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportSemaphoreWin32Handle<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged
            => ImplImportSemaphoreWin32Handle<T0>(semaphore, handleType, handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImportSemaphoreWin32Name([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] void* name)
            => ImplImportSemaphoreWin32Name(semaphore, handleType, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportSemaphoreWin32Name<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged
            => ImplImportSemaphoreWin32Name<T0>(semaphore, handleType, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImportSemaphoreWin32Handle([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] void* handle)
            => ImplImportSemaphoreWin32Handle(semaphore, handleType, handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="handle">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32HandleEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportSemaphoreWin32Handle<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.Out)] Span<T0> handle) where T0 : unmanaged
            => ImplImportSemaphoreWin32Handle<T0>(semaphore, handleType, handle);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ImportSemaphoreWin32Name([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] void* name)
            => ImplImportSemaphoreWin32Name(semaphore, handleType, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreWin32NameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportSemaphoreWin32Name<T0>([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] Span<T0> name) where T0 : unmanaged
            => ImplImportSemaphoreWin32Name<T0>(semaphore, handleType, name);

        public ExtSemaphoreWin32(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

