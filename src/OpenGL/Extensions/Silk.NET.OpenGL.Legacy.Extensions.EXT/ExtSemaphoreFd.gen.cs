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
    [Extension("EXT_semaphore_fd")]
    public unsafe partial class ExtSemaphoreFd : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore_fd";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="fd">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreFdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportSemaphoreF([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] EXT handleType, [Flow(FlowDirection.In)] int fd)
            => ImplImportSemaphoreF(semaphore, handleType, fd);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="semaphore">
        /// To be added.
        /// </param>
        /// <param name="handleType">
        /// To be added.
        /// </param>
        /// <param name="fd">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glImportSemaphoreFdEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ImportSemaphoreF([Flow(FlowDirection.In)] uint semaphore, [Flow(FlowDirection.In)] ExternalHandleType handleType, [Flow(FlowDirection.In)] int fd)
            => ImplImportSemaphoreF(semaphore, handleType, fd);

        public ExtSemaphoreFd(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

