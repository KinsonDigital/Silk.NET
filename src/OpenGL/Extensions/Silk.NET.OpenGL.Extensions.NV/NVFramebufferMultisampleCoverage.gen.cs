// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_framebuffer_multisample_coverage")]
    public unsafe partial class NVFramebufferMultisampleCoverage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_multisample_coverage";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorageMultisampleCoverage(target, coverageSamples, colorSamples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="coverageSamples">
        /// To be added.
        /// </param>
        /// <param name="colorSamples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorageMultisampleCoverage(target, coverageSamples, colorSamples, internalformat, width, height);

        public NVFramebufferMultisampleCoverage(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

