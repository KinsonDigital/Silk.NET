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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_texture_buffer_object")]
    public unsafe partial class ArbTextureBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_buffer_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexBuffer([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplTexBuffer(target, internalformat, buffer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexBufferARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer)
            => ImplTexBuffer(target, internalformat, buffer);

        public ArbTextureBufferObject(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

