// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_texture_view")]
    public unsafe partial class ExtTextureView : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_view";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="origtexture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="minlevel">
        /// To be added.
        /// </param>
        /// <param name="numlevels">
        /// To be added.
        /// </param>
        /// <param name="minlayer">
        /// To be added.
        /// </param>
        /// <param name="numlayers">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureViewEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers)
            => ImplTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="origtexture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="minlevel">
        /// To be added.
        /// </param>
        /// <param name="numlevels">
        /// To be added.
        /// </param>
        /// <param name="minlayer">
        /// To be added.
        /// </param>
        /// <param name="numlayers">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTextureViewEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers)
            => ImplTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);

        public ExtTextureView(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

